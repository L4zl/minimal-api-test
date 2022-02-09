namespace MinimalApiTest.Application.Contracts.Users.Commands;

public class AuthenticateUserCommand : IRequest<AuthenticateUserResponse>
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
