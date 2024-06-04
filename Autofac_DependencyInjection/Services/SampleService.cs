using Autofac_DependencyInjection.Interfaces;

namespace Autofac_DependencyInjection.Services
{
    public class SampleService : ISampleService
    {
        public string GetMessage()
        {
            return "Hello from SampleService!";
        }
    }
}
