using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmquestionWorkflow
    {
        public long SiSmquestionWorkflowId { get; set; }
        public int TargetId { get; set; }
        public string Name { get; set; } = null!;
        public long? ProductGroupId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? StockItemId { get; set; }
        public int? Warranty { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public long? SiSmserviceTypeId { get; set; }
        public int? AppointmentTypeId { get; set; }
        public long? SiconAppointmentLabelId { get; set; }
        public bool? Deleted { get; set; }
    }
}
