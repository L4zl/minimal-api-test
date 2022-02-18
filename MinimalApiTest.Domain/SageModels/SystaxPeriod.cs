using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxPeriod
    {
        public SystaxPeriod()
        {
            SystaxAdjustments = new HashSet<SystaxAdjustment>();
            SystaxPeriodRateBalances = new HashSet<SystaxPeriodRateBalance>();
        }

        public long SystaxPeriodId { get; set; }
        public long SystaxPeriodStatusTypeId { get; set; }
        public short TaxPeriodNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? RunBy { get; set; }
        public DateTime? DateRun { get; set; }
        public decimal LiabilityValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool? OnlineSubmission { get; set; }
        public long? SystaxPeriodSubmitStatusId { get; set; }
        public string? Hmrcreference { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public bool PaidElectronically { get; set; }
        public string PaymentNotification { get; set; } = null!;
        public string ExtraInformation { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public string ChargeRefNumber { get; set; } = null!;
        public string FormBundleNumber { get; set; } = null!;
        public string PaymentIndicator { get; set; } = null!;
        public DateTime? ProcessingDateTime { get; set; }
        public string CorrelationIdentifier { get; set; } = null!;
        public string ReceiptIdentifier { get; set; } = null!;
        public DateTime? PeriodDueDate { get; set; }
        public DateTime? PeriodStartDate { get; set; }
        public DateTime? PeriodEndDate { get; set; }

        public virtual SystaxPeriodStatusType SystaxPeriodStatusType { get; set; } = null!;
        public virtual SystaxPeriodSubmitStatus? SystaxPeriodSubmitStatus { get; set; }
        public virtual ICollection<SystaxAdjustment> SystaxAdjustments { get; set; }
        public virtual ICollection<SystaxPeriodRateBalance> SystaxPeriodRateBalances { get; set; }
    }
}
