using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetField
    {
        public long SiconFixedAssetFieldId { get; set; }
        public string? FieldName { get; set; }
        public bool? Mandatory { get; set; }
        public long? SiconFixedAssetFieldTabId { get; set; }
        public bool? Amendable { get; set; }
        public bool? Active { get; set; }
        public short? SlotIndex { get; set; }
        public string? PropertyName { get; set; }
        public string? DataType { get; set; }
        public short? Scale { get; set; }
    }
}
