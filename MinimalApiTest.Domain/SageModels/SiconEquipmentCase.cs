using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipmentCase
    {
        public SiconEquipmentCase()
        {
            SiSmlabourOnEquipmentCases = new HashSet<SiSmlabourOnEquipmentCase>();
        }

        public long SiconEquipmentCaseId { get; set; }
        public long SiSmcaseId { get; set; }
        public long SiconEquipmentId { get; set; }
        public int? ReturnRepairStatus { get; set; }
        public long? SiSmserviceTypeId { get; set; }
        public bool? ServiceTypeBilled { get; set; }
        public long? RevenueSiJcTrnId { get; set; }
        public int? BillingPlan { get; set; }
        public long? ReportStatusId { get; set; }
        public string? Notes { get; set; }

        public virtual SiJcTrn? RevenueSiJcTrn { get; set; }
        public virtual SiconEquipment SiconEquipment { get; set; } = null!;
        public virtual ICollection<SiSmlabourOnEquipmentCase> SiSmlabourOnEquipmentCases { get; set; }
    }
}
