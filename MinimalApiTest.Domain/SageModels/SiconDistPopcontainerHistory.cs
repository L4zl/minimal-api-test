using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPopcontainerHistory
    {
        public long SiconDistPopcontainerHistoryId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? SiconDistContainerId { get; set; }
        public string PreviousValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string ChangedByUser { get; set; } = null!;
        public DateTime? ChangedDate { get; set; }
        public int PopcontainerHistoryType { get; set; }
        public string PopcontainerHistoryTypeString { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
    }
}
