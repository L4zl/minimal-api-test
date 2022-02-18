using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopinvCredDispute
    {
        public PopinvCredDispute()
        {
            PopinvoiceCreditLines = new HashSet<PopinvoiceCreditLine>();
            Temmessages = new HashSet<Temmessage>();
        }

        public long PopinvCredDisputeId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long PopinvoiceCreditTypeId { get; set; }
        public long SupplierId { get; set; }
        public long? PopdisputeCodeId { get; set; }
        public string DisputeComment { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public DateTime? DocumentDueDate { get; set; }
        public decimal InvCredGoodsValue { get; set; }
        public decimal InvCredTaxValue { get; set; }
        public decimal ExchangeRate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopdisputeCode? PopdisputeCode { get; set; }
        public virtual PopinvoiceCreditType PopinvoiceCreditType { get; set; } = null!;
        public virtual PlsupplierAccount Supplier { get; set; } = null!;
        public virtual ICollection<PopinvoiceCreditLine> PopinvoiceCreditLines { get; set; }
        public virtual ICollection<Temmessage> Temmessages { get; set; }
    }
}
