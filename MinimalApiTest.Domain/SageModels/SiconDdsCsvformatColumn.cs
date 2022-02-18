using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsCsvformatColumn
    {
        public long SiconDdsCsvformatColumnId { get; set; }
        public long? SiconDdsCsvformatSchemaId { get; set; }
        public long? SiconDdsCsvformatFieldId { get; set; }
        public string Caption { get; set; } = null!;
        public int Position { get; set; }
        public int Length { get; set; }
        public int RequiredLength { get; set; }
        public string FormatString { get; set; } = null!;
        public bool RightAlignment { get; set; }
        public bool Mandatory { get; set; }
        public string PaddingCharacter { get; set; } = null!;
        public string FixedValue { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
