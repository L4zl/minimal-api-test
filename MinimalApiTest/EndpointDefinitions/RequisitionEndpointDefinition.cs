namespace MinimalApiTest.EndpointDefinitions;

public class RequisitionEndpointDefinition : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        var userId =
        app.MapGet("/requisition", async (IMediator mediator, IMapper mapper, Microsoft.AspNetCore.Http.HttpContext context)
        =>
        {
            var userId = (context.Items["User"] as UserResponse)?.UserId;

            if (userId is null) return Results.BadRequest();

            return Results.Ok(await mediator.Send(
            new GetAllRequisitionsQuery
            {
                UserId = userId.Value
            }));
        })
            .WithTags("Requisition");
        app.MapGet("/requisition/{id}", async (IMediator mediator, IMapper mapper, long id) => await mediator.Send(new GetRequisitionByIdQuery { Id = id }))
            .WithTags("Requisition");
        app.MapGet("/requisition/count", async (IMediator mediator) => await mediator.Send(new GetAllRequisitionsCountQuery()))
            .WithTags("Requisition");
        app.MapPost("/requisition", async (IMediator mediator, CreateRequisitionCommand command) => await mediator.Send(command))
            .WithTags("Requisition");
        app.MapPut("/requisition/{id}", async (IMediator mediator, long id, UpdateRequisitionCommand command) => await mediator.Send(command))
            .WithTags("Requisition");
        app.MapDelete("/requisition/{id}", async (IMediator mediator, long id) => await mediator.Send(new DeleteRequisitionCommand { Id = id }))
            .WithTags("Requisition");
    }

    public void DefineServices(IServiceCollection services)
    {
        services.AddMediatR(typeof(GetAllRequisitionsQueryHandler));
    }
}

