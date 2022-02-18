using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmappointmentCostingView
    {
        public long SiconAppointmentId { get; set; }
        public string? CaseNumber { get; set; }
        public decimal? Cost { get; set; }
    }
}
