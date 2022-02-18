using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvoiceCreditLine
    {
        public SopinvoiceCreditLine()
        {
            InvoiceLineProfitAnalyses = new HashSet<InvoiceLineProfitAnalysis>();
            SopdespatchReceiptLines = new HashSet<SopdespatchReceiptLine>();
            SoppaymentInvCredLines = new HashSet<SoppaymentInvCredLine>();
            TraceSopinvCredLines = new HashSet<TraceSopinvCredLine>();
        }

        public long SopinvoiceCreditLineId { get; set; }
        public long SopinvoiceCreditId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public short PrintSequenceNumber { get; set; }
        public string DespatchReceiptNos { get; set; } = null!;
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public decimal InvoiceCreditQuantity { get; set; }
        public DateTime InvoiceCreditDate { get; set; }
        public decimal OutstandingQuantity { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public decimal LineDiscountPercent { get; set; }
        public string OrderReturnNo { get; set; } = null!;
        public bool? OrderReturnArchived { get; set; }
        public long? TemmessageId { get; set; }
        public short? TemmessageLineNo { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal ItemPrice { get; set; }
        public long? SystaxRateId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string ItemName { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string ItemUnitOfMeasure { get; set; } = null!;

        public virtual SopinvoiceCredit SopinvoiceCredit { get; set; } = null!;
        public virtual SoporderReturn? SoporderReturn { get; set; }
        public virtual SoporderReturnLine? SoporderReturnLine { get; set; }
        public virtual SystaxRate? SystaxRate { get; set; }
        public virtual ICollection<InvoiceLineProfitAnalysis> InvoiceLineProfitAnalyses { get; set; }
        public virtual ICollection<SopdespatchReceiptLine> SopdespatchReceiptLines { get; set; }
        public virtual ICollection<SoppaymentInvCredLine> SoppaymentInvCredLines { get; set; }
        public virtual ICollection<TraceSopinvCredLine> TraceSopinvCredLines { get; set; }
    }
}
