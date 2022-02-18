using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseType
    {
        public long SiSmcaseTypeId { get; set; }
        public string? Name { get; set; }
        public string? WorkReportOverridePath { get; set; }
        public long? DefaultSiconAppointmentLabelId { get; set; }
    }
}
