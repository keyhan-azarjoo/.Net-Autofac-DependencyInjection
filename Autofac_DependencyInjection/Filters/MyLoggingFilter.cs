using Autofac_DependencyInjection.Interfaces;
using Autofac_DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Autofac_DependencyInjection.Filters
{
    public class MyLoggingFilter : IActionFilter
    {
        private readonly IKeyhanConfiguration keyhanConfiguration;
        private readonly ISampleService sampleService;
        public MyLoggingFilter(IKeyhanConfiguration _keyhanConfiguration, ISampleService _sampleService)
        {
            keyhanConfiguration = _keyhanConfiguration;
            sampleService = _sampleService;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            keyhanConfiguration.SetConfiguration("this is my configuration");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var myConfig = keyhanConfiguration.GetConfiguration();


            var ss = sampleService.GetMessage();
        }
    }
}
