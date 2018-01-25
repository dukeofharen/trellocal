using System.Collections.Generic;
using System.Threading.Tasks;
using Trellocal.Models.Trello;

namespace Trellocal.Services.Interfaces
{
   public interface ITrelloConnector
   {
      Task<IEnumerable<TrelloBoard>> GetBoardsAsync();

      Task<IEnumerable<TrelloCard>> GetCardsAsync(string boardId);

      Task<IEnumerable<TrelloList>> GetListsAsync(string boardId);

      Task<IEnumerable<TrelloAction>> GetActionsAsync(string cardId);

      Task<IEnumerable<TrelloAttachment>> GetAttachmentsAsync(string cardId);

      Task<IEnumerable<TrelloChecklist>> GetChecklistsAsync(string cardId);
   }
}
