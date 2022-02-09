namespace MinimalApiTest.Application.Services.Users.Queries;
public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserResponse>
{
    private readonly IWapContext _context;
    private readonly IMapper _mapper;

    public GetUserByIdQueryHandler(IWapContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<UserResponse> Handle(GetUserByIdQuery query, CancellationToken cancellationToken)
    {
        var users = await _context.Users
        .AsNoTracking()
        .FirstOrDefaultAsync(u => u.UserId == query.Id && !(u.Deleted ?? true), cancellationToken)
        ?? throw new Exception();
        return _mapper.Map<UserResponse>(users);
    }
}