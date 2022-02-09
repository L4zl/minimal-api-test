namespace MinimalApiTest.Application.Services.Requisitions.Queries;

public class GetAllRequisitionsCountQueryHandler : IRequestHandler<GetAllRequisitionsCountQuery, long>
{
    private readonly IWapContext _context;
    private readonly RequisitionQueryExtensions _queryExtensions;

    public GetAllRequisitionsCountQueryHandler(IWapContext context)
    {
        _context = context;
        _queryExtensions = new RequisitionQueryExtensions(_context);
    }

    public async Task<long> Handle(GetAllRequisitionsCountQuery query, CancellationToken cancellationToken)
        => await _queryExtensions.GetUsersAvaliableRequisitions(query.UserId).CountAsync(cancellationToken);
}

