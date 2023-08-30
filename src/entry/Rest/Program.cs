using Core.Features;
using Rest;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

ServicesProvider servicesProvider = new();
builder.Services.AddScoped<ServicesProvider.Scope>(_ => servicesProvider.CreateScope());

WebApplication app = builder.Build();

app.MapPost("/user", (ServicesProvider.Scope provider, CreateUserCommand command) =>
{
     IUseCaseHandler handler = provider.GetService<IUseCaseHandler>();
});


await app.RunAsync();