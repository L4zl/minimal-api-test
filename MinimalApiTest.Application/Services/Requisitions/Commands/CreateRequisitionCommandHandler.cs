namespace MinimalApiTest.Application.Services.Requisitions.Commands;
public class CreateRequisitionCommandHandler : IRequestHandler<CreateRequisitionCommand, int>
{
    private readonly IWapContext _context;
    public CreateRequisitionCommandHandler(IWapContext context) => _context = context;
    public async Task<int> Handle(CreateRequisitionCommand command, CancellationToken cancellationToken)
    {
        await _context.Orders.AddAsync(new Order(), cancellationToken);
        return await _context.SaveChangesAsync(cancellationToken);
    }
}

