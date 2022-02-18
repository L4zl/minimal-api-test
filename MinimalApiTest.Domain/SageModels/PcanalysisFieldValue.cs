using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcanalysisFieldValue
    {
        public PcanalysisFieldValue()
        {
            PccostGroupAnalysisFields = new HashSet<PccostGroupAnalysisField>();
            PccostItemAnalysisFields = new HashSet<PccostItemAnalysisField>();
            PcprojectItemAnalysisFields = new HashSet<PcprojectItemAnalysisField>();
        }

        public long PcanalysisFieldValueId { get; set; }
        public long PcanalysisFieldId { get; set; }
        public bool ShowValueInList { get; set; }
        public string? TextValue { get; set; }
        public decimal? NumericValue { get; set; }
        public DateTime? DateValue { get; set; }
        public bool? YesNoValue { get; set; }
        public bool? Active { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? TshumanResourceId { get; set; }
        public long? StockItemId { get; set; }
        public long? TimeValue { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcanalysisField PcanalysisField { get; set; } = null!;
        public virtual PlsupplierAccount? PlsupplierAccount { get; set; }
        public virtual SlcustomerAccount? SlcustomerAccount { get; set; }
        public virtual StockItem? StockItem { get; set; }
        public virtual TshumanResource? TshumanResource { get; set; }
        public virtual ICollection<PccostGroupAnalysisField> PccostGroupAnalysisFields { get; set; }
        public virtual ICollection<PccostItemAnalysisField> PccostItemAnalysisFields { get; set; }
        public virtual ICollection<PcprojectItemAnalysisField> PcprojectItemAnalysisFields { get; set; }
    }
}
