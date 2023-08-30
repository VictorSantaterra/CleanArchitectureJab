namespace Core;

public sealed class User
{
    public required UserId Id { get; init; }
    public required UserName UserName { get; init; }
}

public sealed record UserName(string Value);
public sealed record UserId(Guid Value);