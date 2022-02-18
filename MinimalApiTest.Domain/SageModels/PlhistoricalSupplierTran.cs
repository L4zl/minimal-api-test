using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlhistoricalSupplierTran
    {
        public PlhistoricalSupplierTran()
        {
            CbgroupHistSupplierTrans = new HashSet<CbgroupHistSupplierTran>();
            PlhistRevalAllocationTrans = new HashSet<PlhistRevalAllocationTran>();
        }

        public long PlhistoricalSupplierTranId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long? CbaccountId { get; set; }
        public decimal AllocatedValue { get; set; }
        public short DaysDiscountValid { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime DueDate { get; set; }
        public decimal GoodsValueInAccountCurrency { get; set; }
        public decimal PurControlValueInBaseCurrency { get; set; }
        public decimal DocumentToBaseCurrencyRate { get; set; }
        public decimal DocumentToAccountCurrencyRate { get; set; }
        public DateTime PostedDate { get; set; }
        public string QueryCode { get; set; } = null!;
        public string TransactionReference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public long Source { get; set; }
        public long SystraderTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public decimal TaxValue { get; set; }
        public DateTime DateTransactionMovedToHistory { get; set; }
        public DateTime? FullSettlementDate { get; set; }
        public short FullSettlementPeriodInDays { get; set; }
        public long SystraderGenerateReasonTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool Revalued { get; set; }
        public decimal EffectiveExchangeRate { get; set; }
        public long? NominalAccountingPeriodId { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public bool IsSettledImmediately { get; set; }
        public bool IsVatadjustmentDocumentExpected { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long SyscorrectionTranTypeId { get; set; }

        public virtual Cbaccount? Cbaccount { get; set; }
        public virtual SysaccountingPeriod? NominalAccountingPeriod { get; set; }
        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
        public virtual SyscorrectionTranType SyscorrectionTranType { get; set; } = null!;
        public virtual SystraderGenerateReasonType SystraderGenerateReasonType { get; set; } = null!;
        public virtual SystraderTranType SystraderTranType { get; set; } = null!;
        public virtual ICollection<CbgroupHistSupplierTran> CbgroupHistSupplierTrans { get; set; }
        public virtual ICollection<PlhistRevalAllocationTran> PlhistRevalAllocationTrans { get; set; }
    }
}
