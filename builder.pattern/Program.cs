using builder.pattern.Builder;
using builder.pattern.Entities;

string userName = "ocb_dev";
string name = "Oscar";
string lastName = "Chavez";
string email = "oscar@example.com";

Account withOutBuilder = new()
{
    Name = name,
    LastName = lastName,
    FullName = $"{name} {lastName}",
    Email = email,
};

Account creatingWithBuilder = new AccountBuilder()
                            .SetUserName(userName)
                            .SetFullName(name, lastName)
                            .SetEmail(email)
                            .Build();

Account updatingWithBuilder = new AccountBuilder(creatingWithBuilder)
                            .SetEmail("other_email@example.com")
                            .Build();