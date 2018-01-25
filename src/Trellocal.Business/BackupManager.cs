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
         var boards = await connector.GetBoardsAsync();

         foreach (var board in boards)
         {
            var lists = await connector.GetListsAsync(board.Id);
            var cards = await connector.GetCardsAsync(board.Id);
            foreach (var card in cards)
            {
               var actions = await connector.GetActionsAsync(card.Id);
               var attachments = await connector.GetAttachmentsAsync(card.Id);
               var checklists = await connector.GetChecklistsAsync(card.Id);
            }
         }
      }
   }
}
