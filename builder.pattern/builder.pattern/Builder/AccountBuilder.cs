using Ardalis.GuardClauses;

using builder.pattern.Entities;

namespace builder.pattern.Builder;

public sealed class AccountBuilder : IBuilder<Account>
{
    private readonly Account _account;

    public AccountBuilder()
        => _account = new Account();

    public AccountBuilder (Account account)
        => _account = Guard.Against.Null(account, nameof(account));

    public AccountBuilder SetUserName(string userName)
    {
        _account.UserName = Guard.Against.NullOrEmpty(userName, nameof(userName));
        return this;
    }

    public AccountBuilder SetFullName(string name, string lastName)
    {
        _account.Name = Guard.Against.NullOrEmpty(name, nameof(name));
        _account.LastName = Guard.Against.NullOrEmpty(lastName, nameof(lastName));

        _account.FullName = $"{_account.Name} {_account.LastName}";
        return this;
    }

    public AccountBuilder SetEmail(string email)
    {
        _account.Email = Guard.Against.NullOrEmpty(email, nameof(email));
        return this;
    }

    public Account Build()
        => _account;
}
