namespace MinimalApiTest.Application.Contracts.Users.Queries;

public class GetUserByUsernameQuery : IRequest<UserResponse>
{
    public string Name;
}

