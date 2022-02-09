namespace MinimalApiTest.Application.Contracts.Users.Responses;

public class AuthenticateUserResponse
{
    public long Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Username { get; private set; }
    public string Token { get; private set; }
    public DateTime ExpiredTime { get; private set; }


    public AuthenticateUserResponse(long id, string username, string firstName, string lastName, string token)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Username = username;
        Token = token;
    }
}

