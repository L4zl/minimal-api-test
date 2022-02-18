using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmtaskTypeAttribute
    {
        public long SiconTcmtaskTypeAttributeId { get; set; }
        public long? SiconTcmattributeId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public long SiconTcmtaskTypeId { get; set; }
    }
}
