namespace Trellocal.Connection.Interfaces
{
   public interface ITrelloConnectorFactory
   {
      ITrelloConnector GetTrelloConnector(string apiKey, string oauthToken);
   }
}
