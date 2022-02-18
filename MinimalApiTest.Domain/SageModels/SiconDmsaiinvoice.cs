using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsaiinvoice
    {
        public long SiconDmsaiinvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public string SupplierErpid { get; set; } = null!;
        public string SupplierName { get; set; } = null!;
        public int ApplicationId { get; set; }
        public int SupplierId { get; set; }
        public int ProcessId { get; set; }
        public int StateId { get; set; }
        public int StageId { get; set; }
        public string Source { get; set; } = null!;
        public DateTime? CreationTime { get; set; }
        public int AiinvoiceStatusId { get; set; }
        public int ValidationStatusId { get; set; }
        public bool ResetFeedback { get; set; }
        public string QueryCode { get; set; } = null!;
        public string QueryNote { get; set; } = null!;
        public string? QueryUser { get; set; }
        public DateTime? QueryDate { get; set; }
        public bool? ManualTrainingApplied { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public string AiinvoiceGrnstatus { get; set; } = null!;
    }
}
