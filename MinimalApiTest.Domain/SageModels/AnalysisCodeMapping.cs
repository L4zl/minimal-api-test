using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class AnalysisCodeMapping
    {
        public AnalysisCodeMapping()
        {
            PopanalysisCodeAnalysisCodeMappings = new HashSet<PopanalysisCode>();
            PopanalysisCodeSupplierAnalysisCodeMappings = new HashSet<PopanalysisCode>();
            PopanalysisCodeTranHistAnalysisCodeMappings = new HashSet<PopanalysisCode>();
            SopanalysisCodeAnalysisCodeMappings = new HashSet<SopanalysisCode>();
            SopanalysisCodeCustomerAnalysisCodeMappings = new HashSet<SopanalysisCode>();
            SopanalysisCodeTranHistAnalysisCodeMappings = new HashSet<SopanalysisCode>();
        }

        public long AnalysisCodeMappingId { get; set; }
        public string ClassName { get; set; } = null!;
        public string FriendlyClassName { get; set; } = null!;
        public string PropertyName { get; set; } = null!;
        public string FriendlyPropertyName { get; set; } = null!;
        public int SlotIndex { get; set; }
        public long? AnalysisCodeId { get; set; }
        public bool IsMandatory { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PopanalysisCode> PopanalysisCodeAnalysisCodeMappings { get; set; }
        public virtual ICollection<PopanalysisCode> PopanalysisCodeSupplierAnalysisCodeMappings { get; set; }
        public virtual ICollection<PopanalysisCode> PopanalysisCodeTranHistAnalysisCodeMappings { get; set; }
        public virtual ICollection<SopanalysisCode> SopanalysisCodeAnalysisCodeMappings { get; set; }
        public virtual ICollection<SopanalysisCode> SopanalysisCodeCustomerAnalysisCodeMappings { get; set; }
        public virtual ICollection<SopanalysisCode> SopanalysisCodeTranHistAnalysisCodeMappings { get; set; }
    }
}
