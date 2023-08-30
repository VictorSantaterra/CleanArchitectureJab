using Core.Repositories;
using Persistence.Repositories;
using Jab;

namespace Persistence;

[ServiceProviderModule]
[Transient<IUseCaseRepository, UseCaseRepository>]
public interface IPersistenceServicesProvider { }