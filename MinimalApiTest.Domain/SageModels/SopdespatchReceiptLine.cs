using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopdespatchReceiptLine
    {
        public SopdespatchReceiptLine()
        {
            SopdespatchLineProfitAnalyses = new HashSet<SopdespatchLineProfitAnalysis>();
            SopdespatchReceiptLineShortfalls = new HashSet<SopdespatchReceiptLineShortfall>();
            TraceSopdespRcptLines = new HashSet<TraceSopdespRcptLine>();
        }

        public long SopdespatchReceiptLineId { get; set; }
        public long SopdespatchReceiptId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long? SopinvoiceCreditLineId { get; set; }
        public string DespatchReceiptNo { get; set; } = null!;
        public string OrderReturnNo { get; set; } = null!;
        public string InvoiceCreditNo { get; set; } = null!;
        public long BinItemId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public decimal DespatchReceiptQuantity { get; set; }
        public DateTime DespatchReceiptDate { get; set; }
        public bool IsInvoiced { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long IntrastatStatusId { get; set; }
        public decimal StockUnitDespRcptQuantity { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual IntrastatStatus IntrastatStatus { get; set; } = null!;
        public virtual SopdespatchReceipt SopdespatchReceipt { get; set; } = null!;
        public virtual SopinvoiceCreditLine? SopinvoiceCreditLine { get; set; }
        public virtual SoporderReturnLine SoporderReturnLine { get; set; } = null!;
        public virtual ICollection<SopdespatchLineProfitAnalysis> SopdespatchLineProfitAnalyses { get; set; }
        public virtual ICollection<SopdespatchReceiptLineShortfall> SopdespatchReceiptLineShortfalls { get; set; }
        public virtual ICollection<TraceSopdespRcptLine> TraceSopdespRcptLines { get; set; }
    }
}
