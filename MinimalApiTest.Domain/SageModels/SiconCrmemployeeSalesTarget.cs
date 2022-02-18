using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmemployeeSalesTarget
    {
        public long SiconCrmemployeeSalesTargetId { get; set; }
        public long EmployeeId { get; set; }
        public long SysfinancialYearId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public decimal SalesTarget { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
