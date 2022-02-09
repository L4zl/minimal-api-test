namespace MinimalApiTest.EndpointDefinitions
{
    public class AutoMapperEndpointDefinitions : IEndpointDefinition
    {
        public void DefineEndpoints(WebApplication app)
        {
        }

        public void DefineServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(RequisitionProfile));
        }
    }
}
