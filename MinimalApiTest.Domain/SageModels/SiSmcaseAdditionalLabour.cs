using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseAdditionalLabour
    {
        public long SiSmcaseAdditionalLabourId { get; set; }
        public long SiSmcaseId { get; set; }
        public long SiconResourceId { get; set; }
        public string? SiconResourceFullName { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public DateTime? ActualDate { get; set; }
        public decimal? ActualHours { get; set; }
        public decimal? InvoicedHours { get; set; }
        public string? Notes { get; set; }
        public long? ChargeRateId { get; set; }
        public long? SiconAppointmentLabelId { get; set; }
    }
}
