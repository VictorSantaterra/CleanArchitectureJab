using Jab;
using Core;
using Persistence;

[Import<IPersistenceServicesProvider>]
[Import<ICoreServicesProvider>]
[ServiceProvider]
internal sealed partial class ServicesProvider
{
}