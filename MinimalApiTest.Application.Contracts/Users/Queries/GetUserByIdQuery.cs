namespace MinimalApiTest.Application.Contracts.Users.Queries;

public class GetUserByIdQuery : IRequest<UserResponse>
{
    public long Id { get; set; }
}

