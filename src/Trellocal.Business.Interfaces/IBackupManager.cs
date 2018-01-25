using System.Threading.Tasks;

namespace Trellocal.Business.Interfaces
{
   public interface IBackupManager
   {
      Task RunBackupAsync(string apiKey, string oauthToken);
   }
}
