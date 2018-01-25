using System;

namespace Trellocal.Exceptions
{
   public class TrellocalException : Exception
   {
      public TrellocalException(string message) : base(message)
      {
      }
   }
}
