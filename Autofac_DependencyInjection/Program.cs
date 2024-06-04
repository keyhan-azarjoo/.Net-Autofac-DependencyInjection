using Autofac.Extensions.DependencyInjection;
using Autofac;
using Autofac_DependencyInjection;
using Autofac_DependencyInjection.Filters;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddControllers(opt =>
{
    // Adding Global filter attribute here for test dependency injection from Autofac
    opt.Filters.Add(typeof(MyLoggingFilter));// This is a filter which Runs befor and after any request to controllers
                                            
});







// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();







// Configure Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    // Register your own services within Autofac
    containerBuilder.RegisterModule(new AutofacModule());
});








var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
