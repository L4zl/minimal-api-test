namespace MinimalApiTest.Application.Services.Requisitions.Queries;

public class GetRequisitionByIdQueryHandler : IRequestHandler<GetRequisitionByIdQuery, RequisitionDetailedResponse>
{
    private readonly IWapContext _context;
    private readonly IMapper _mapper;
    private readonly RequisitionQueryExtensions _queryExtensions;
    public GetRequisitionByIdQueryHandler(IWapContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _queryExtensions = new RequisitionQueryExtensions(_context);
    }

    public async Task<RequisitionDetailedResponse> Handle(GetRequisitionByIdQuery query, CancellationToken cancellationToken)
    {
        var order = await _queryExtensions.GetUsersAvaliableRequisitions(query.UserId)
             .AsNoTracking()
             .FirstOrDefaultAsync(o => o.OrderId == query.Id && !(o.Deleted ?? true), cancellationToken)
             ?? throw new Exception();
        var req = _mapper.Map<RequisitionDetailedResponse>(order);

        req.RequisitionLines = await _context.OrderLines
            .Where(l => l.OrderId == query.Id && !(l.Deleted ?? true))
            .Select(l => _mapper.Map<RequisitionLineResponse>(l))
            .ToListAsync(cancellationToken);

        return req;
    }
}

