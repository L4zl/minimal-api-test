using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsextractField
    {
        public long SiconDmsextractFieldId { get; set; }
        public string SupplierErpid { get; set; } = null!;
        public string FieldName { get; set; } = null!;
        public string ExtractFieldName { get; set; } = null!;
        public int ExtractFieldIndex { get; set; }
        public string SeperatorCharacter { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
