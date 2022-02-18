namespace MinimalApiTest.Infrastructure.Persistence;

public class SageContexts : ISageContexts
{
    public IEnumerable<ISageContext> GetAllContexts(List<string> connections)
    {
        return connections.Select(c => new SageContext(c));
    }

    public ISageContext GetContext(string connection)
    {
        return new SageContext(connection);
    }
}

