using Core.Features;
using Jab;

namespace Core;

[ServiceProviderModule]
[Transient<IUseCaseHandler, UseCaseHandler>]
[Transient<TransientService1>]
[Transient<TransientService2>]
[Transient<TransientService3>]
[Scoped<ScopedService>]
[Singleton<SingletonService>]
public interface ICoreServicesProvider
{
}