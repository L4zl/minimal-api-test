using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentAttribute
    {
        public long SiconDmsdocumentAttributeId { get; set; }
        public long? SiconDmsattributeId { get; set; }
        public string AttributeValue { get; set; } = null!;
        public string? AttributeValueString { get; set; }
        public DateTime? AttributeValueDateTime { get; set; }
        public long? AttributeValueInteger { get; set; }
        public decimal? AttributeValueDecimal { get; set; }
        public bool? AttributeValueBool { get; set; }
        public long? SiconDmsdocumentId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
