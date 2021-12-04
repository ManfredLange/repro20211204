using System;
using Castle.DynamicProxy;

namespace FooService
{
   public class AnAspect : IInterceptor
   {
      public void Intercept(IInvocation invocation)
      {
         RecordInvocation(invocation);
         invocation.Proceed();
      }

      private static void RecordInvocation(IInvocation _)
      {
         Console.WriteLine("AnAspect is injected.");
      }
   }
}
