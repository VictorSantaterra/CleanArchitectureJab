using Core.Features;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
ServicesProvider servicesProvider = new();

WebApplication app = builder.Build();

app.Use(async (context, next) =>
{
    await using var scope = servicesProvider.CreateScope();

    context.Items[nameof(ServicesProvider.Scope)] = scope;

    await next();
});

app.MapPost("/user", (HttpContext context, CreateUserCommand command) =>
{
    ServicesProvider.Scope provider = (ServicesProvider.Scope)context.Items[nameof(ServicesProvider.Scope)]!;

    IUseCaseHandler handler = provider.GetService<IUseCaseHandler>();
});


await app.RunAsync();