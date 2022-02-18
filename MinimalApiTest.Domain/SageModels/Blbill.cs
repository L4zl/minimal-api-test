using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Blbill
    {
        public Blbill()
        {
            BlbillEvents = new HashSet<BlbillEvent>();
            BlbillLines = new HashSet<BlbillLine>();
            PcprojectEntries = new HashSet<PcprojectEntry>();
        }

        public long BlbillId { get; set; }
        public long SlcustomerId { get; set; }
        public long BlbillHeaderStatusId { get; set; }
        public string Reference { get; set; } = null!;
        public decimal ToBaseCurrencyRate { get; set; }
        public short EarlySettlementDiscountDays { get; set; }
        public decimal EarlySettlementDiscount { get; set; }
        public long BlbillDeliveryAddressId { get; set; }
        public bool UseInvoiceAddressAsDeliveryAddress { get; set; }
        public string BillNumber { get; set; } = null!;
        public DateTime DocumentDate { get; set; }
        public decimal TotalChargesValue { get; set; }
        public decimal TotalDiscountedNetValue { get; set; }
        public decimal TotalDiscountValue { get; set; }
        public decimal TotalGrossValue { get; set; }
        public decimal TotalGrossValueInclSettDisc { get; set; }
        public decimal TotalNetValue { get; set; }
        public decimal TotalTax { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public decimal DocumentDiscountPercent { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BlbillDeliveryAddress BlbillDeliveryAddress { get; set; } = null!;
        public virtual BlbillHeaderStatus BlbillHeaderStatus { get; set; } = null!;
        public virtual ICollection<BlbillEvent> BlbillEvents { get; set; }
        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
    }
}
