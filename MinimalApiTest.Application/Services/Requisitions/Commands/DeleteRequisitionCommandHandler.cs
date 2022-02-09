namespace MinimalApiTest.Application.Services.Requisitions.Commands;

public class DeleteRequisitionCommandHandler : IRequestHandler<DeleteRequisitionCommand, int>
{
    private readonly IWapContext _context;
    public DeleteRequisitionCommandHandler(IWapContext context) => _context = context;
    public async Task<int> Handle(DeleteRequisitionCommand command, CancellationToken cancellationToken)
    {
        var order = await _context.Orders.FirstOrDefaultAsync(u => u.OrderId == command.Id) ?? throw new Exception();
        order.Deleted = true;
        return await _context.SaveChangesAsync(cancellationToken);
    }
}

