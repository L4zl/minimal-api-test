using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprcptReturnLineArch
    {
        public PoprcptReturnLineArch()
        {
            PoprcptRtnInvCrdLineArches = new HashSet<PoprcptRtnInvCrdLineArch>();
        }

        public long PopreceiptReturnLineId { get; set; }
        public long PopreceiptReturnId { get; set; }
        public long PoporderReturnLineId { get; set; }
        public string ReceiptReturnNo { get; set; } = null!;
        public string OrderReturnNo { get; set; } = null!;
        public decimal InvoiceCreditQuantity { get; set; }
        public long? BinItemId { get; set; }
        public string BinName { get; set; } = null!;
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public decimal ReceiptReturnQuantity { get; set; }
        public DateTime? ReceiptReturnDate { get; set; }
        public long? PoprcptRtnLineSourceId { get; set; }
        public string SupplierDocumentNo { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal StockUnitBuyingPrice { get; set; }
        public decimal ExchangeRate { get; set; }
        public long IntrastatStatusId { get; set; }
        public decimal StockUnitRcptRtnQuantity { get; set; }
        public decimal StockUnitInvCredQuantity { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BinItem? BinItem { get; set; }
        public virtual IntrastatStatus IntrastatStatus { get; set; } = null!;
        public virtual PoporderReturnLineArch PoporderReturnLine { get; set; } = null!;
        public virtual PoprcptRtnLineSource? PoprcptRtnLineSource { get; set; }
        public virtual ICollection<PoprcptRtnInvCrdLineArch> PoprcptRtnInvCrdLineArches { get; set; }
    }
}
