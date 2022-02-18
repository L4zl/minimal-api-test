using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmworkAppointmentTravelSummary
    {
        public long SiconAppointmentId { get; set; }
        public string? Subject { get; set; }
        public decimal? ToMileage { get; set; }
        public decimal? FromMileage { get; set; }
        public decimal? TotalMileage { get; set; }
        public decimal? ToHours { get; set; }
        public decimal? FromHours { get; set; }
        public decimal? TotalHours { get; set; }
    }
}
