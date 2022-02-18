using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlpendCustomerBatchTran
    {
        public SlpendCustomerBatchTran()
        {
            SlpendNlanalysisBatchTrans = new HashSet<SlpendNlanalysisBatchTran>();
            SlpendTaxAnalysisBatchTrans = new HashSet<SlpendTaxAnalysisBatchTran>();
        }

        public long SlpendCustomerBatchTranId { get; set; }
        public long SlpendCustomerBatchId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long? CbaccountId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public decimal GoodsValueInAccountCurrency { get; set; }
        public decimal TaxValue { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal DiscountPercentage { get; set; }
        public short DaysDiscountValid { get; set; }
        public decimal AllocatedValue { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public decimal DocumentToBaseCurrencyRate { get; set; }
        public decimal DocumentToAccountExchangeRate { get; set; }
        public decimal ChequeToAccountCurrencyRate { get; set; }
        public decimal BankChequeToBaseCurrencyRate { get; set; }
        public long? ChequeCurrencyId { get; set; }
        public decimal TraderChequeValue { get; set; }
        public string? BankNominalAccountNumber { get; set; }
        public string? BankNominalCostCentre { get; set; }
        public string? BankNominalDepartment { get; set; }
        public string? BankNominalAccountName { get; set; }
        public bool AuthorisationFlag { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool TriangularTransaction { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public bool IsSettledImmediately { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Cbaccount? Cbaccount { get; set; }
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
        public virtual SlpendCustomerBatch SlpendCustomerBatch { get; set; } = null!;
        public virtual ICollection<SlpendNlanalysisBatchTran> SlpendNlanalysisBatchTrans { get; set; }
        public virtual ICollection<SlpendTaxAnalysisBatchTran> SlpendTaxAnalysisBatchTrans { get; set; }
    }
}
