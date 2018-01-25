using System;
using System.Threading.Tasks;
using Trellocal.Business.Interfaces;
using Trellocal.Services.Interfaces;

namespace Trellocal.Business
{
   internal class BackupManager : IBackupManager
   {
      private readonly ITrelloConnectorFactory _trelloConnectorFactory;

      public BackupManager(ITrelloConnectorFactory trelloConnectorFactory)
      {
         _trelloConnectorFactory = trelloConnectorFactory;
      }

      public async Task RunBackupAsync(string apiKey, string oauthToken)
      {
         var connector = _trelloConnectorFactory.GetTrelloConnector(apiKey, oauthToken);
         var boards = await connector.GetBoards();
      }
   }
}
