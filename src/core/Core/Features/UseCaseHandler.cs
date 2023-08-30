using Core.Repositories;

namespace Core.Features;

public interface IUseCaseHandler
    : IHandler<CreateUserCommand, CreateUserResponse>
{
}

public sealed class UseCaseHandler : IUseCaseHandler
{
    private readonly TransientService1 _transientService1;
    private readonly TransientService2 _transientService2;
    private readonly TransientService3 _transientService3;
    private readonly ScopedService _scopedService;
    private readonly SingletonService _singletonService;

    public UseCaseHandler(
        TransientService1 transientService1,
        TransientService2 transientService2,
        TransientService3 transientService3,
        ScopedService scopedService,
        SingletonService singletonService)
    {
        _transientService1 = transientService1;
        _transientService2 = transientService2;
        _transientService3 = transientService3;
        _scopedService = scopedService;
        _singletonService = singletonService;
    }

    public Task<CreateUserResponse> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

public sealed class TransientService1
{
    private readonly ScopedService _scopedService;
    private readonly SingletonService _singletonService;

    public TransientService1(
        ScopedService scopedService,
        SingletonService singletonService)
    {
        _scopedService = scopedService;
        _singletonService = singletonService;
    }

    public Guid Id = Guid.NewGuid();

}

public sealed class TransientService2
{
    private readonly ScopedService _scopedService;

    public TransientService2(
        ScopedService scopedService)
    {
        _scopedService = scopedService;
    }

    public Guid Id = Guid.NewGuid();

}

public sealed class TransientService3
{
    private readonly SingletonService _singletonService;
    public TransientService3(SingletonService singletonService)
    {
        _singletonService = singletonService;
    }

    public Guid Id = Guid.NewGuid();
}

public sealed class ScopedService
{
    private readonly SingletonService _singletonService;
    public ScopedService(SingletonService singletonService)
    {
        _singletonService = singletonService;
    }

    public Guid Id = Guid.NewGuid();
}

public sealed class SingletonService
{
    public Guid Id = Guid.NewGuid();
}

public sealed record CreateUserCommand(string UserName);

public sealed record CreateUserResponse(Guid UserId);

public interface IHandler<in TCommand, TResponse>
{
    Task<TResponse> Handle(TCommand command, CancellationToken cancellationToken);
}