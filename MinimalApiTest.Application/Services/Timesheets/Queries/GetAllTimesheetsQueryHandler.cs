using MinimalApiTest.Application.Contracts.Timesheets;
using MinimalApiTest.Application.Contracts.Timesheets.Queries;
using MinimalApiTest.Domain.SageModels;

namespace MinimalApiTest.Application.Services.Timesheets.Queries;

public class GetAllTimesheetsQueryHandler : IRequestHandler<GetAllTimesheetsQuery, IEnumerable<TimesheetSummaryResponse>>
{
    private readonly SageConnectionStrings _sageConnections;
    private readonly IMapper _mapper;
    private readonly ISageContexts _contexts;
    public GetAllTimesheetsQueryHandler(ISageContexts contexts, IOptions<SageConnectionStrings> sageConnections, IMapper mapper)
    {
        _sageConnections = sageConnections.Value;
        _mapper = mapper;
        _contexts = contexts;
    }

    public async Task<IEnumerable<TimesheetSummaryResponse>> Handle(GetAllTimesheetsQuery query, CancellationToken cancellationToken)
    {
        var timesheets = new List<TimesheetSummaryResponse>();
        var contexts = _contexts.GetAllContexts(_sageConnections.connectionStrings);
        var contextIndex = 0;
        foreach (ISageContext context in contexts)
        {
            var list = await context.SiconTimesheets.ToListAsync(cancellationToken);
            timesheets.AddRange(list.Select(l => _mapper.Map<SiconTimesheet, TimesheetSummaryResponse>(l, o => o.Items["SageDatabaseId"] = contextIndex)));
            contextIndex++;
        }
        return timesheets;
    }
}

