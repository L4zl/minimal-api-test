using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcanalysisFieldValueView
    {
        public long PcanalysisFieldValueId { get; set; }
        public long PcanalysisFieldId { get; set; }
        public string? FieldType { get; set; }
        public string? FieldValue { get; set; }
    }
}
