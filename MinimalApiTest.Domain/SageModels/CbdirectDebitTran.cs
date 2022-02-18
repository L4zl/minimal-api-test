using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbdirectDebitTran
    {
        public CbdirectDebitTran()
        {
            CbpendAccountTrans = new HashSet<CbpendAccountTran>();
            CbpostedAccountTrans = new HashSet<CbpostedAccountTran>();
            CbshortTermCashProjectionTrans = new HashSet<CbshortTermCashProjectionTran>();
        }

        public long CbdirectDebitTranId { get; set; }
        public long CbaccountId { get; set; }
        public long CbdirectDebitDocumentTypeId { get; set; }
        public long CbdirectDebitTranTypeId { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public bool Vatable { get; set; }
        public long? SystaxRateId { get; set; }
        public decimal TotalValue { get; set; }
        public decimal TotalTaxValue { get; set; }
        public DateTime? FirstPaymentDate { get; set; }
        public decimal FirstTaxPaymentValue { get; set; }
        public short NumberOfPayments { get; set; }
        public decimal FirstPaymentValue { get; set; }
        public decimal LastPaymentValue { get; set; }
        public decimal LastTaxPaymentValue { get; set; }
        public decimal RegularPaymentValue { get; set; }
        public decimal RegularTaxPaymentValue { get; set; }
        public long CbpaymentFrequencyId { get; set; }
        public short PaymentDayOfMonth { get; set; }
        public string ExpenseAccountNumber { get; set; } = null!;
        public string NominalExpenseCostCentre { get; set; } = null!;
        public string NominalExpenseDepartment { get; set; } = null!;
        public short NumberOfPaymentsMade { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public decimal ValueOfPaymentsMade { get; set; }
        public decimal TaxOfPaymentsMade { get; set; }
        public DateTime? LastPaymentMadeDate { get; set; }
        public string Text { get; set; } = null!;
        public long Source { get; set; }
        public string TransactionAnalysisCode { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
        public virtual CbdirectDebitDocumentType CbdirectDebitDocumentType { get; set; } = null!;
        public virtual CbdirectDebitTranType CbdirectDebitTranType { get; set; } = null!;
        public virtual CbpaymentFrequency CbpaymentFrequency { get; set; } = null!;
        public virtual NlnominalAccount? NlnominalAccount { get; set; }
        public virtual PlsupplierAccount? PlsupplierAccount { get; set; }
        public virtual SlcustomerAccount? SlcustomerAccount { get; set; }
        public virtual SystaxRate? SystaxRate { get; set; }
        public virtual ICollection<CbpendAccountTran> CbpendAccountTrans { get; set; }
        public virtual ICollection<CbpostedAccountTran> CbpostedAccountTrans { get; set; }
        public virtual ICollection<CbshortTermCashProjectionTran> CbshortTermCashProjectionTrans { get; set; }
    }
}
