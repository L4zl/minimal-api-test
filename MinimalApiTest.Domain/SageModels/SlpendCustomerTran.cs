using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlpendCustomerTran
    {
        public SlpendCustomerTran()
        {
            SlpendNlanalysisTrans = new HashSet<SlpendNlanalysisTran>();
            SlpendTaxAnalysisTrans = new HashSet<SlpendTaxAnalysisTran>();
        }

        public long SlpendCustomerTranId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SystraderTranTypeId { get; set; }
        public long? CbaccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public decimal GoodsValueInAccountCurrency { get; set; }
        public decimal SalControlValueInBaseCurrency { get; set; }
        public decimal TaxValue { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal DiscountPercentage { get; set; }
        public short DaysDiscountValid { get; set; }
        public DateTime DueDate { get; set; }
        public decimal DocumentToBaseCurrencyRate { get; set; }
        public decimal DocumentToAccountExchangeRate { get; set; }
        public DateTime PostedDate { get; set; }
        public string QueryCode { get; set; } = null!;
        public long Source { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public int UserNumber { get; set; }
        public long SystraderGenerateReasonTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? NominalPeriodModule { get; set; }
        public decimal? ChequeToBankExchangeRate { get; set; }
        public long? ChequeCurrencyId { get; set; }
        public decimal? ChequeValueInChequeCurrency { get; set; }
        public bool TriangularTransaction { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public bool IsSettledImmediately { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string PaymentCloudPaymentId { get; set; } = null!;

        public virtual Cbaccount? Cbaccount { get; set; }
        public virtual Syscurrency? ChequeCurrency { get; set; }
        public virtual Sysmodule? NominalPeriodModuleNavigation { get; set; }
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
        public virtual SystraderGenerateReasonType SystraderGenerateReasonType { get; set; } = null!;
        public virtual SystraderTranType SystraderTranType { get; set; } = null!;
        public virtual ICollection<SlpendNlanalysisTran> SlpendNlanalysisTrans { get; set; }
        public virtual ICollection<SlpendTaxAnalysisTran> SlpendTaxAnalysisTrans { get; set; }
    }
}
