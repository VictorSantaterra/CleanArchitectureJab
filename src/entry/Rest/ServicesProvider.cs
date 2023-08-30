using Core;
using Jab;
using Persistence;

namespace Rest;

[Import<IPersistenceServicesProvider>]
[Import<ICoreServicesProvider>]
[ServiceProvider]
internal sealed partial class ServicesProvider
{
}