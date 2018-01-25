using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Trellocal.Exceptions;
using Trellocal.Models.Trello;
using Trellocal.Services.Interfaces;

namespace Trellocal.Services
{
   internal class TrelloConnector : ITrelloConnector
   {
      private int _counter = 0;
      private readonly HttpClient _httpClient = new HttpClient();
      private readonly string _apiKey;
      private readonly string _oauthToken;

      public TrelloConnector(string apiKey, string oauthToken)
      {
         _apiKey = apiKey;
         _oauthToken = oauthToken;
      }

      public async Task<IEnumerable<TrelloBoard>> GetBoardsAsync()
      {
         string url = $"https://api.trello.com/1/members/username/boards?key={_apiKey}&token={_oauthToken}";
         return await ExecuteRequestAsync<TrelloBoard[]>(url);
      }

      public async Task<IEnumerable<TrelloCard>> GetCardsAsync(string boardId)
      {
         string url = $"https://api.trello.com/1/boards/{boardId}/cards?key={_apiKey}&token={_oauthToken}";
         return await ExecuteRequestAsync<TrelloCard[]>(url);
      }

      public async Task<IEnumerable<TrelloList>> GetListsAsync(string boardId)
      {
         string url = $"https://api.trello.com/1/boards/{boardId}/lists?key={_apiKey}&token={_oauthToken}";
         return await ExecuteRequestAsync<TrelloList[]>(url);
      }

      public async Task<IEnumerable<TrelloAction>> GetActionsAsync(string cardId)
      {
         string url = $"https://api.trello.com/1/cards/{cardId}/actions?key={_apiKey}&token={_oauthToken}";
         return await ExecuteRequestAsync<TrelloAction[]>(url);
      }

      public async Task<IEnumerable<TrelloAttachment>> GetAttachmentsAsync(string cardId)
      {
         string url = $"https://api.trello.com/1/cards/{cardId}/attachments?key={_apiKey}&token={_oauthToken}";
         return await ExecuteRequestAsync<TrelloAttachment[]>(url);
      }

      public async Task<IEnumerable<TrelloChecklist>> GetChecklistsAsync(string cardId)
      {
         string url = $"https://api.trello.com/1/cards/{cardId}/checklists?key={_apiKey}&token={_oauthToken}";
         return await ExecuteRequestAsync<TrelloChecklist[]>(url);
      }

      private async Task<TResult> ExecuteRequestAsync<TResult>(string url)
      {
         // This is done because of Trello rate limiting: 100 requests per 10 seconds.
         if (_counter % 100 == 0)
         {
            await Task.Delay(1000);
         }

         using (var response = await _httpClient.GetAsync(url))
         {
            if (response.StatusCode != HttpStatusCode.OK)
            {
               throw new TrellocalException($"Unexpected status coder received from Trello: '{response.StatusCode}'");
            }

            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TResult>(content);
            _counter++;
            return result;
         }
      }
   }
}
