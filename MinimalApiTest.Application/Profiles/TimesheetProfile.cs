using MinimalApiTest.Application.Contracts.Timesheets;
using MinimalApiTest.Domain.SageModels;

namespace MinimalApiTest.Application.Profiles;

public class TimesheetProfile : Profile
{
    public TimesheetProfile()
    {
        CreateMap<SiconTimesheet, TimesheetSummaryResponse>()
            .ForMember(
            dest => dest.SageDatabaseId,
            opt => opt.MapFrom((src, dest, destMember, context) => context.Items["SageDatabaseId"]));
    }
}

