namespace MinimalApiTest.Application.Contracts.Requisitions.Commands;

public class UpdateRequisitionCommand : IRequest<int>
{
    public long Id { get; set; }
}

