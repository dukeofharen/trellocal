namespace Trellocal.Services.Interfaces
{
   public interface ITrelloConnectorFactory
   {
      ITrelloConnector GetTrelloConnector(string apiKey, string oauthToken);
   }
}
