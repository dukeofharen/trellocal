using Trellocal.Business.Interfaces;
using Trellocal.Services.Interfaces;

namespace Trellocal.Business
{
   public static class DependencyRegistration
   {
      public static void RegisterDependencies(IServiceContainerWrapper wrapper)
      {
         wrapper.RegisterSingleton(wrapper);
         wrapper.RegisterType<IBackupManager, BackupManager>();

         Services.DependencyRegistration.RegisterDependencies(wrapper);
      }
   }
}
