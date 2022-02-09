namespace MinimalApiTest.Application.Contracts.Requisitions.Queries;

public class GetAllRequisitionsQuery : IRequest<IEnumerable<RequisitionSummaryResponse>>
{
    public long UserId { get; set; }
}

