namespace MinimalApiTest.Application.Services.Requisitions.Queries;

public class GetAllRequisitionsQueryHandler : IRequestHandler<GetAllRequisitionsQuery, IEnumerable<RequisitionSummaryResponse>>
{
    private readonly IWapContext _context;
    private readonly RequisitionQueryExtensions _queryExtensions;
    private readonly IMapper _mapper;
    public GetAllRequisitionsQueryHandler(IWapContext context, IMapper mapper)
    {
        _context = context;
        _queryExtensions = new RequisitionQueryExtensions(_context);
        _mapper = mapper;
    }

    public async Task<IEnumerable<RequisitionSummaryResponse>> Handle(GetAllRequisitionsQuery query, CancellationToken cancellationToken)
      => await _queryExtensions
            .GetUsersAvaliableRequisitions(query.UserId)
            .AsNoTracking()
            .Select(x => _mapper.Map<RequisitionSummaryResponse>(x))
            .ToListAsync(cancellationToken)
            ?? throw new Exception();
}

