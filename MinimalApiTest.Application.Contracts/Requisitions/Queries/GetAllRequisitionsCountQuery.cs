namespace MinimalApiTest.Application.Contracts.Requisitions.Queries;

public class GetAllRequisitionsCountQuery : IRequest<long>
{
    public long UserId { get; set; } = 1;
}

