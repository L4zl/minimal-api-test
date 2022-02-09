namespace MinimalApiTest.Application.Services.Users.Queries;

public class GetUserByUsernameQueryHandler : IRequestHandler<GetUserByUsernameQuery, UserResponse>
{
    private readonly IWapContext _context;
    private readonly IMapper _mapper;

    public GetUserByUsernameQueryHandler(IWapContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserResponse> Handle(GetUserByUsernameQuery query, CancellationToken cancellationToken)
        => await _context.Users
        .AsNoTracking()
        .Select(u => _mapper.Map<UserResponse>(u))
        .FirstOrDefaultAsync(u => u.UserName == query.Name && (!u.Deleted ?? false), cancellationToken)
        ?? throw new Exception();
}


