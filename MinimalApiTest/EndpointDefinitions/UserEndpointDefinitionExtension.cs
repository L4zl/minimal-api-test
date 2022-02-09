namespace MinimalApiTest.EndpointDefinitions;

public class UserEndpointDefinitionExtension : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapPost("/user/login", async (IMediator mediator, IMapper mapper, AuthenticateUserCommand command) 
            => await mediator.Send(command)).WithTags("Authentication")
            .AllowAnonymous();
    }

    public void DefineServices(IServiceCollection services)
    {
        services.AddMediatR(typeof(GetAllRequisitionsQueryHandler));
    }
}

