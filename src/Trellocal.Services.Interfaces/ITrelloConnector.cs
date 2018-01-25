using System.Collections.Generic;
using System.Threading.Tasks;
using Trellocal.Models.Trello;

namespace Trellocal.Services.Interfaces
{
   public interface ITrelloConnector
   {
      Task<IEnumerable<Board>> GetBoards();
   }
}
