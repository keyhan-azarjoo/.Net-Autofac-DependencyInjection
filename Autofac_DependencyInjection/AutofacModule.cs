using Autofac;
using Autofac_DependencyInjection.Interfaces;
using Autofac_DependencyInjection.Services;

namespace Autofac_DependencyInjection
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Register your services here
            builder.RegisterType<SampleService>().As<ISampleService>().InstancePerLifetimeScope();
            builder.RegisterType<KeyhanConfiguration>().As<IKeyhanConfiguration>().InstancePerLifetimeScope();
        }
    }
}


