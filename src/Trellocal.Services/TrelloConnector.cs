using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
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
       
       public Task<IEnumerable<Board>> GetBoards()
       {
          throw new NotImplementedException();
       }
    }
}
