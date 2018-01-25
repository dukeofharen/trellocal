using Trellocal.Connection;
using Trellocal.Services.Interfaces;

namespace Trellocal.Services
{
    internal class TrelloConnectorFactory : ITrelloConnectorFactory
    {
       public ITrelloConnector GetTrelloConnector(string apiKey, string oauthToken)
       {
          return new TrelloConnector(apiKey, oauthToken);
       }
    }
}
