namespace MinimalApiTest.Application.Services.Requisitions.Helpers;

public class RequisitionQueryExtensions
{
    private readonly IWapContext _context;
    public RequisitionQueryExtensions(IWapContext context) => _context = context;
    public IQueryable<Order> GetUsersAvaliableRequisitions(long id) => from order in _context.Orders.Where(o => !(o.Deleted ?? true))
                                                                       join sageDb in _context.SageDatabases.Where(s => !(s.Deleted ?? true))
                                                                       on order.SageDatabaseId equals sageDb.SageDatabaseId
                                                                       join userDb in _context.UserSageDatabases.Where(udb => udb.UserId == id)
                                                                       on sageDb.SageDatabaseId equals userDb.SageDatabaseId
                                                                       select order;
}

