namespace MinimalApiTest.Application.Profiles;

public class RequisitionProfile : Profile
{
    public RequisitionProfile()
    {
        CreateMap<Order, RequisitionSummaryResponse>()
            .ForMember(
            dest => dest.ID,
            opt => opt.MapFrom(o => o.OrderId));
        CreateMap<Order, RequisitionDetailedResponse>()
            .ForMember(
            dest => dest.RequisitionLines,
            opt => opt.Ignore());
        CreateMap<OrderLine, RequisitionLineResponse>();
    }
}

