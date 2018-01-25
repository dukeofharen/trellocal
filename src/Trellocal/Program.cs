using System.Threading.Tasks;
using Trellocal.Business;
using Trellocal.Business.Interfaces;
using Trellocal.DI.Unity;

namespace Trellocal
{
   class Program
   {
      static async Task Main(string[] args)
      {
         var wrapper = UnityServiceContainerWrapper.GetInstance();
         DependencyRegistration.RegisterDependencies(wrapper);
         var backupManager = wrapper.Resolve<IBackupManager>();
      }
   }
}
