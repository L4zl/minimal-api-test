using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmappointmentCommittedRevenueView
    {
        public long SiconAppointmentId { get; set; }
        public string? CaseNumber { get; set; }
        public decimal? CommittedRevenue { get; set; }
    }
}
