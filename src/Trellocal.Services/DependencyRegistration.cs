using Trellocal.Services.Interfaces;

namespace Trellocal.Services
{
   public static class DependencyRegistration
   {
      public static void RegisterDependencies(IServiceContainerWrapper wrapper)
      {
         wrapper.RegisterType<ITrelloConnectorFactory, TrelloConnectorFactory>();
      }
   }
}
