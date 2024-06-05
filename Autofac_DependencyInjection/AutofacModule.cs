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


            // Using Dependency injection allows you to change your classes whenever you like by just changing SampleService to a betterSampleService and change the SampleService to betterSampleService here
            //Furthermore you can test your code with any data you like without changing the real data. You just need to pass yourConfiguration instead of MyConfiguration in the unitest, which is really easy.


            
            // If your services count is not many you can register them one by one here 
            //but if the number of your classes are many and it is hard to register them one by one you can use the other code at the end of this page
            
            builder.RegisterType<SampleService>().As<ISampleService>().InstancePerLifetimeScope();
            builder.RegisterType<KeyhanConfiguration>().As<IKeyhanConfiguration>().InstancePerLifetimeScope();






            //// We can use this code to automate the registration process for two special Folder
            //// Here at the where condition we find all classes in Services and add them to Registration
            //// at the As we get all interfaces and Check for Interfaces folder and check for those that start with I and put them there.
            //// If the number of classes and Interfaces is not too much it is better to register them manually otherwise it is better to register all of them in one code like here.
            
            //var assembly = Assembly.Load(nameof(Autofac_DependencyInjection)); // Autofac_DependencyInjection is the name of project
            //builder.RegisterAssemblyTypes(assembly)
            //    .Where(t => t.Namespace != null && t.Namespace.Contains("Services")) // Services is the name of the folder that our classes are their
            //    .As(t => {
            //        var interfaceType = t.GetInterfaces()
            //            .FirstOrDefault(i => i.Namespace != null && i.Namespace.Contains("Interfaces") && i.Name == "I" + t.Name); // Interfaces is the name of folder that our Interfaces are ther
            //        return interfaceType ?? throw new InvalidOperationException($"No matching interface found for type {t.Name}");
            //    });
            





          

            ////// // This is the same as the above code but it is simpler as both classes and Interfaces are in the same folder
            
            //////builder.RegisterAssemblyTypes(Assembly.Load(nameof(Autofac_DependencyInjection)))
            //////    .Where(t => t.Namespace.Contains("Services"))
            //////    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            
        }
    }
}


