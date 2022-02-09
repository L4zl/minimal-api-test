namespace MinimalApiTest.Application.Services.Requisitions.Commands;

public class UpdateRequisitionCommandHandler : IRequestHandler<UpdateRequisitionCommand, int>
{
    private readonly IWapContext _context;
    public UpdateRequisitionCommandHandler(IWapContext context) => _context = context;
    public async Task<int> Handle(UpdateRequisitionCommand command, CancellationToken cancellationToken)
    {
        var order = await _context.Orders
            .FirstOrDefaultAsync(o => o.OrderId == command.Id, cancellationToken)
            ?? throw new Exception();
        order.UpdatedDate = DateTime.Now;
        return await _context.SaveChangesAsync(cancellationToken);
    }
}

