using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbpostedAccountTran
    {
        public CbpostedAccountTran()
        {
            CbgroupHistCustomerTrans = new HashSet<CbgroupHistCustomerTran>();
            CbgroupHistSupplierTrans = new HashSet<CbgroupHistSupplierTran>();
            CbgroupPostedCustomerTrans = new HashSet<CbgroupPostedCustomerTran>();
            CbgroupPostedSupplierTrans = new HashSet<CbgroupPostedSupplierTran>();
            PlproposedPayments = new HashSet<PlproposedPayment>();
        }

        public long CbpostedAccountTranId { get; set; }
        public long CbaccountId { get; set; }
        public long CbtranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public decimal ChequeValue { get; set; }
        public decimal ChequeDiscountValue { get; set; }
        public long ChequeSyscurrencyId { get; set; }
        public decimal ChequeToBaseCurrExchangeRate { get; set; }
        public decimal ChequeToAccountExchangeRate { get; set; }
        public DateTime PostedDate { get; set; }
        public long Source { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public int StandingOrderDdreference { get; set; }
        public string NominalOrTraderAccountNumber { get; set; } = null!;
        public string NominalAccountCostCentre { get; set; } = null!;
        public string NominalAccountDepartment { get; set; } = null!;
        public string ChequeDescription { get; set; } = null!;
        public decimal StatementValue { get; set; }
        public int? StatementPageNumber { get; set; }
        public DateTime? LastStatementDate { get; set; }
        public long? CbdirectDebitTranId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? NominalAccountingPeriodId { get; set; }
        public string QueryReason { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public string? SagePaymentsIdentifier { get; set; }
        public long SagePaymentsTransactionStatusId { get; set; }
        public bool SagePaymentsHasNote { get; set; }
        public int? BankFeedReconciliationStatus { get; set; }
        public long SyscorrectionTranTypeId { get; set; }

        public virtual Cbaccount Cbaccount { get; set; } = null!;
        public virtual CbdirectDebitTran? CbdirectDebitTran { get; set; }
        public virtual CbtranType CbtranType { get; set; } = null!;
        public virtual Syscurrency ChequeSyscurrency { get; set; } = null!;
        public virtual SysaccountingPeriod? NominalAccountingPeriod { get; set; }
        public virtual SagePaymentsTransactionStatus SagePaymentsTransactionStatus { get; set; } = null!;
        public virtual SyscorrectionTranType SyscorrectionTranType { get; set; } = null!;
        public virtual CbdraftStatementPostTranLink CbdraftStatementPostTranLink { get; set; } = null!;
        public virtual ICollection<CbgroupHistCustomerTran> CbgroupHistCustomerTrans { get; set; }
        public virtual ICollection<CbgroupHistSupplierTran> CbgroupHistSupplierTrans { get; set; }
        public virtual ICollection<CbgroupPostedCustomerTran> CbgroupPostedCustomerTrans { get; set; }
        public virtual ICollection<CbgroupPostedSupplierTran> CbgroupPostedSupplierTrans { get; set; }
        public virtual ICollection<PlproposedPayment> PlproposedPayments { get; set; }
    }
}
