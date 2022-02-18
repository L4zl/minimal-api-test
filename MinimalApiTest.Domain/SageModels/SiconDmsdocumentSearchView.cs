using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdocumentSearchView
    {
        public long SiconDmsdocumentId { get; set; }
        public long? SiconDmsdocumentTypeEntityId { get; set; }
        public long? SiconDmsentityModuleId { get; set; }
        public string DataType { get; set; } = null!;
        public string AttributeValue { get; set; } = null!;
        public string? AttributeValueString { get; set; }
        public DateTime? AttributeValueDateTime { get; set; }
        public long? AttributeValueInteger { get; set; }
        public decimal? AttributeValueDecimal { get; set; }
        public bool? AttributeValueBool { get; set; }
        public string AttributeName { get; set; } = null!;
        public string AttributeFriendlyName { get; set; } = null!;
        public long SiconDmsattributeId { get; set; }
        public long SiconDmsdocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; } = null!;
        public string DocumentTypeFriendlyName { get; set; } = null!;
        public long SiconDmsmoduleId { get; set; }
        public string ModuleName { get; set; } = null!;
        public string ModuleFriendlyName { get; set; } = null!;
        public long SiconDmsentityId { get; set; }
        public string EntityName { get; set; } = null!;
        public string EntityFriendlyName { get; set; } = null!;
    }
}
