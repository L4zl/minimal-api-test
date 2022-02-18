using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcustomFieldListValue
    {
        public long SiconCrmcustomFieldListValueId { get; set; }
        public long SiconCrmcustomFieldId { get; set; }
        public string ListValue { get; set; } = null!;
        public short Sequence { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
