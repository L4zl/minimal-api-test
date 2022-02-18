using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmemployeeSetting
    {
        public long SiconCrmemployeeSettingId { get; set; }
        public long EmployeeId { get; set; }
        public short UserLevel { get; set; }
        public bool ExportToExcel { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public bool SendTasksToCalendar { get; set; }
        public bool EditSageLinkedRecords { get; set; }
    }
}
