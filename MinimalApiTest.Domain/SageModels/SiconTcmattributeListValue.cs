using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmattributeListValue
    {
        public long SiconTcmattributeListValueId { get; set; }
        public long? SiconTcmattributeListId { get; set; }
        public string ListValue { get; set; } = null!;
        public string ListValueString { get; set; } = null!;
        public DateTime? ListValueDateTime { get; set; }
        public int ListValueInteger { get; set; }
        public decimal ListValueDecimal { get; set; }
        public bool ListValueBool { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
