namespace MinimalApiTest.Domain.Abstractions;

public interface ISageContexts
{
    IEnumerable<ISageContext> GetAllContexts(List<string> connections);

    ISageContext GetContext(string connection);

}

