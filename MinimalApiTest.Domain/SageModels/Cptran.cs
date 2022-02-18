using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Cptran
    {
        public Cptran()
        {
            CpallocationTranPaymentCptrans = new HashSet<CpallocationTran>();
            CpallocationTranRefundCptrans = new HashSet<CpallocationTran>();
            CpentityCptrans = new HashSet<CpentityCptran>();
        }

        public long CptranId { get; set; }
        public long CpcardProcessorTranTypeId { get; set; }
        public string TranCode { get; set; } = null!;
        public string AuthNumber { get; set; } = null!;
        public string SecurityKey { get; set; } = null!;
        public string CardProcessorTranCode { get; set; } = null!;
        public decimal Value { get; set; }
        public decimal AllocatedValue { get; set; }
        public string CurrencyIsocode { get; set; } = null!;
        public string CpcardProcessor { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; } = null!;
        public string User { get; set; } = null!;
        public string CardType { get; set; } = null!;

        public virtual CpcardProcessorTranType CpcardProcessorTranType { get; set; } = null!;
        public virtual ICollection<CpallocationTran> CpallocationTranPaymentCptrans { get; set; }
        public virtual ICollection<CpallocationTran> CpallocationTranRefundCptrans { get; set; }
        public virtual ICollection<CpentityCptran> CpentityCptrans { get; set; }
    }
}
