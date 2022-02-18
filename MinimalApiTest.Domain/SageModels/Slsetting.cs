using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Slsetting
    {
        public long SlsettingId { get; set; }
        public bool CopyStatementsForHeadOffices { get; set; }
        public bool AllowBatchProcessing { get; set; }
        public bool AutoGenerateAccountNumbers { get; set; }
        public int NextAccountNumber { get; set; }
        public bool AllowAdditionalTransAnalysis { get; set; }
        public short EarlySettlementDiscountDays { get; set; }
        public decimal EarlySettlementDiscountPercent { get; set; }
        public short KeepTransactionsFor { get; set; }
        public bool ArchiveTransactionAfterKeeping { get; set; }
        public short BadDebtVatrecoveryWaitPeriod { get; set; }
        public long DefaultSystaxRateId { get; set; }
        public short NumberOfAgeingPeriods { get; set; }
        public short DefaultPaymentTermsDays { get; set; }
        public long SyspaymentTermsBasisId { get; set; }
        public bool UseForeignCurrencyRevaluation { get; set; }
        public long SltranToShowOnStatementsId { get; set; }
        public long SldateToUseForAgeingId { get; set; }
        public bool ChargeInterestOnFinanceCharges { get; set; }
        public int NumberOfBatchesThisPeriod { get; set; }
        public bool? UseAccountPeriodsAsTradPeriods { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool? DefaultTermsAgreed { get; set; }
        public bool UseCardProcessing { get; set; }
        public bool? ShowOutstandingTrans { get; set; }
        public long MaxEnquiryTransToDisplay { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public bool CaptureAdditionalTransactionDetails { get; set; }

        public virtual SystaxRate DefaultSystaxRate { get; set; } = null!;
        public virtual SldateToUseForAgeing SldateToUseForAgeing { get; set; } = null!;
        public virtual SltranToShowOnStatement SltranToShowOnStatements { get; set; } = null!;
        public virtual SyspaymentTermsBasis SyspaymentTermsBasis { get; set; } = null!;
    }
}
