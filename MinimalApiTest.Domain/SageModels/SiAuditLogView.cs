using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiAuditLogView
    {
        public DateTime? DateChanged { get; set; }
        public DateTime? DateApproved { get; set; }
        public long AuditId { get; set; }
        public string Module { get; set; } = null!;
        public string Type { get; set; } = null!;
        public long? SageRecordKey { get; set; }
        public string Field { get; set; } = null!;
        public string OldValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public DateTime? ChangedDate { get; set; }
        public string ChangedUser { get; set; } = null!;
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedUser { get; set; } = null!;
        public bool Approved { get; set; }
        public string Reference { get; set; } = null!;
        public string Reference2 { get; set; } = null!;
        public string ValueType { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public long? ParentSageRecordKey { get; set; }
        public int PrintSequenceNumber { get; set; }
    }
}
