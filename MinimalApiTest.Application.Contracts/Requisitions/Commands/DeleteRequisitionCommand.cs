namespace MinimalApiTest.Application.Contracts.Requisitions.Commands;

public class DeleteRequisitionCommand : IRequest<int>
{
    public long Id { get; set; }
}

