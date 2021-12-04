
using Autofac;
using Autofac.Extras.DynamicProxy;
using FooService.Controllers;

namespace FooService
{
   public class AutofacModule : Module
   {
      protected override void Load(ContainerBuilder containerBuilder)
      {
         // Register controllers
         containerBuilder
            .RegisterType<WeatherForecastController>()
            .EnableClassInterceptors()
            .InterceptedBy(typeof(AnAspect))
            ;

         // Others
         containerBuilder
            .RegisterType<AnAspect>()
            ;
      }
   }
}
