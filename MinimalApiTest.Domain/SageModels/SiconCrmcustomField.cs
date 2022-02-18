using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcustomField
    {
        public long SiconCrmcustomFieldId { get; set; }
        public short FieldNumber { get; set; }
        public string Entity { get; set; } = null!;
        public string FieldLabel { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public string SelectStatement { get; set; } = null!;
        public bool IsEnabled { get; set; }
        public bool IsMandatory { get; set; }
        public bool ShowInLists { get; set; }
        public bool ShowInFilters { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public long? SiconCrmcompanyTypeId { get; set; }
        public long? SiconCrmaccountTypeId { get; set; }
    }
}
