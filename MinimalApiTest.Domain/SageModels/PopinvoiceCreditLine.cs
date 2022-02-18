using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopinvoiceCreditLine
    {
        public PopinvoiceCreditLine()
        {
            PoprcptRtnInvCredLines = new HashSet<PoprcptRtnInvCredLine>();
            TracePopinvCredLines = new HashSet<TracePopinvCredLine>();
        }

        public long PopinvoiceCreditLineId { get; set; }
        public string PopinvoiceCreditNo { get; set; } = null!;
        public long? PopinvCredDisputeId { get; set; }
        public long PoporderReturnLineId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public decimal InvoiceCreditQuantity { get; set; }
        public DateTime? InvoiceCreditDate { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public bool IsDisputed { get; set; }
        public decimal DiscountedUnitPrice { get; set; }
        public decimal ReceiptReturnQuantity { get; set; }
        public long PopinvoiceCreditTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal StockUnitRcptRtnQuantity { get; set; }
        public decimal StockUnitInvCredQuantity { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopinvCredDispute? PopinvCredDispute { get; set; }
        public virtual PopinvoiceCreditType PopinvoiceCreditType { get; set; } = null!;
        public virtual PoporderReturnLine PoporderReturnLine { get; set; } = null!;
        public virtual ICollection<PoprcptRtnInvCredLine> PoprcptRtnInvCredLines { get; set; }
        public virtual ICollection<TracePopinvCredLine> TracePopinvCredLines { get; set; }
    }
}
