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
      private readonly HttpClient _httpClient = new HttpClient();
      private readonly string _apiKey;
      private readonly string _oauthToken;

      public TrelloConnector(string apiKey, string oauthToken)
      {
         _apiKey = apiKey;
         _oauthToken = oauthToken;
      }

      public async Task<IEnumerable<Board>> GetBoards()
      {
         string url = $"https://api.trello.com/1/members/username/boards?key={_apiKey}&token={_oauthToken}";
         using (var response = await _httpClient.GetAsync(url))
         {
            if (response.StatusCode != HttpStatusCode.OK)
            {
               throw new TrellocalException($"Unexpected status coder received from Trello: '{response.StatusCode}'");
            }

            string content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Board[]>(content);
            return result;
         }
      }
   }
}
