using Trellocal.Services.Interfaces;

namespace Trellocal.Business
{
   public static class DependencyRegistration
   {
      public static void RegisterDependencies(IServiceContainerWrapper wrapper)
      {
         wrapper.RegisterSingleton(wrapper);

         Services.DependencyRegistration.RegisterDependencies(wrapper);
      }
   }
}
