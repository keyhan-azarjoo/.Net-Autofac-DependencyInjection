using Autofac_DependencyInjection.Interfaces;

namespace Autofac_DependencyInjection.Services
{
    public class KeyhanConfiguration : IKeyhanConfiguration
    {

        public string config = null;

        public bool SetConfiguration(string _config)
        {
            // Saving information in anyware
            config = _config;
            return true;
        }

        public string GetConfiguration()
        {
            return config;
        }
    }
}
