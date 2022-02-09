namespace MinimalApiTest.Application.Services.Users.Queries;


public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserResponse>>
{
    private readonly IWapContext _context;
    private readonly IMapper _mapper;

    public GetAllUsersQueryHandler(IWapContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<IEnumerable<UserResponse>> Handle(GetAllUsersQuery query, CancellationToken cancellationToken) =>
        await _context.Users
        .AsNoTracking()
        .Where(u => !u.Deleted ?? false)
        .OrderBy(u => u.UserName)
        .Select(u => _mapper.Map<UserResponse>(u))
        .ToListAsync(cancellationToken)
        ?? throw new Exception();

}


