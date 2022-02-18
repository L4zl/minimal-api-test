using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class InvinvoiceCreditLine
    {
        public InvinvoiceCreditLine()
        {
            BlbillLineInvoiceCreditLines = new HashSet<BlbillLineInvoiceCreditLine>();
            PcprojectEntryPostings = new HashSet<PcprojectEntryPosting>();
        }

        public long InvinvoiceCreditLineId { get; set; }
        public long InvinvoiceCreditId { get; set; }
        public decimal LineDiscountPercent { get; set; }
        public decimal LineTotalValue { get; set; }
        public bool IsCommentOnly { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public decimal ItemPrice { get; set; }
        public decimal InvoiceCreditQuantity { get; set; }
        public string ItemUnitOfMeasure { get; set; } = null!;
        public int PrintSequenceNumber { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public string PriceUnitOfMeasure { get; set; } = null!;
        public decimal LineTaxValue { get; set; }
        public long? SystaxRateId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime InvoiceCreditDate { get; set; }
        public string SourceAreaType { get; set; } = null!;
        public string SourceAreaReference { get; set; } = null!;
        public string SourceAreaName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual InvinvoiceCredit InvinvoiceCredit { get; set; } = null!;
        public virtual SystaxRate? SystaxRate { get; set; }
        public virtual ICollection<BlbillLineInvoiceCreditLine> BlbillLineInvoiceCreditLines { get; set; }
        public virtual ICollection<PcprojectEntryPosting> PcprojectEntryPostings { get; set; }
    }
}
