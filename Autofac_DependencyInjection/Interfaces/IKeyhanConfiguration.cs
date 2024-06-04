namespace Autofac_DependencyInjection.Interfaces
{
    public interface IKeyhanConfiguration
    {
        bool SetConfiguration(string config);
        string GetConfiguration();
    }
}
