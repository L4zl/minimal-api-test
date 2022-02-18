using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPopstagedNomAccLine
    {
        public long SiconPopstagedNomAccLineId { get; set; }
        public long PoporderReturnId { get; set; }
        public long PoporderReturnLineId { get; set; }
        public string AccruedDocumentNo { get; set; } = null!;
        public short AccruedPrintSequenceNumber { get; set; }
        public DateTime AccruedDate { get; set; }
        public decimal AccruedLineQuantity { get; set; }
        public decimal AccruedReceiptReturnQuantity { get; set; }
        public decimal AccruedInvoiceCreditQuantity { get; set; }
        public decimal AccruedLineTotalValue { get; set; }
        public string AccruedNominalAccountRef { get; set; } = null!;
        public string AccruedNominalCostCentre { get; set; } = null!;
        public string AccruedNominalDepartment { get; set; } = null!;
        public string? AccruedNarrative { get; set; }
        public decimal OutstandingAccrualValue { get; set; }
        public decimal GrniaccrualValue { get; set; }
        public string? NominalJournalUrns { get; set; }
        public long? SiJcTrnId { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
