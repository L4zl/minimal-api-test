using MinimalApiTest.Application.Contracts.Timesheets.Queries;
using MinimalApiTest.Application.Services.Timesheets.Queries;

namespace MinimalApiTest.EndpointDefinitions;

    public class SageTimesheetEndpointDefinitions : IEndpointDefinition
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/timesheets", async (IMediator mediator, IMapper mapper) => await mediator.Send(new GetAllTimesheetsQuery())).WithTags("Timesheets");
    }

    public void DefineServices(IServiceCollection services)
    {
        services.AddMediatR(typeof(GetAllTimesheetsQueryHandler));
    }
}

