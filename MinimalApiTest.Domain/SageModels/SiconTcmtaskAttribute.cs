using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmtaskAttribute
    {
        public long SiconTcmtaskAtrributeId { get; set; }
        public long? SiconTcmattributeId { get; set; }
        public long? SiconTcmtaskId { get; set; }
        public string AttributeValue { get; set; } = null!;
        public string AttributeValueString { get; set; } = null!;
        public DateTime? AttributeValueDateTime { get; set; }
        public int AttributeValueInteger { get; set; }
        public decimal AttributeValueDecimal { get; set; }
        public bool AttributeValueBool { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
