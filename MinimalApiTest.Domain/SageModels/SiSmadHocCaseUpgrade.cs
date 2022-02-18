using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmadHocCaseUpgrade
    {
        public long SiSmadHocCaseUpgradeId { get; set; }
        public long TempAppointmentId { get; set; }
        public long TempCaseId { get; set; }
        public long NewAppointmentId { get; set; }
        public long NewCaseId { get; set; }
    }
}
