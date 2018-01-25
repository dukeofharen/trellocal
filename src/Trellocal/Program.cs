using System;
using Trellocal.DI.Unity;

namespace Trellocal
{
   class Program
   {
      static void Main(string[] args)
      {
         var wrapper = UnityServiceContainerWrapper.GetInstance();
      }
   }
}
