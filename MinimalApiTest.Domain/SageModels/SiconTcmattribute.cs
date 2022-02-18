using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmattribute
    {
        public long SiconTcmattributeId { get; set; }
        public string AttributeName { get; set; } = null!;
        public string AttributeFriendlyName { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public bool Deleted { get; set; }
        public bool IsGlobal { get; set; }
        public bool IsSystem { get; set; }
        public bool IsMandatory { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsMeta { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public long? SiconTcmattributeListId { get; set; }
    }
}
