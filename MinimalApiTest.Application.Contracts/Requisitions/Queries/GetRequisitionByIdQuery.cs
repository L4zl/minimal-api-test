namespace MinimalApiTest.Application.Contracts.Requisitions.Queries;

public class GetRequisitionByIdQuery : IRequest<RequisitionDetailedResponse>
{
    public long Id { get; set; }
    public long UserId { get; set; } = 1;
}

