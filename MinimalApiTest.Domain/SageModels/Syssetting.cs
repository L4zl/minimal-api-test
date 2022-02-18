using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Syssetting
    {
        public long SyssettingId { get; set; }
        public short NumberOpenAccountPeriodsPermit { get; set; }
        public bool SplitPostingBetweenCostCentres { get; set; }
        public bool AllowAdditionalTransAnalysis { get; set; }
        public string TransactionAnalysisHeading { get; set; } = null!;
        public bool UpdateNominalImmediately { get; set; }
        public bool ProduceIntrastatDeclarations { get; set; }
        public bool UsePeriodExchangeRates { get; set; }
        public DateTime FinancialYearEndDate { get; set; }
        public bool? UseAccountPeriodsAsTradPeriods { get; set; }
        public bool InvoiceCreditNoteSameNumbers { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public int BuildVersion { get; set; }
        public decimal IntrastatValueForConsolidation { get; set; }
        public decimal ReverseChargeMinimum { get; set; }
        public bool? UseSegmentedAddress { get; set; }
        public bool TemailEnabled { get; set; }
        public bool FirstVatreturnDateDefined { get; set; }
        public bool ExchangeRateInvoicing { get; set; }
        public bool EditExchangeRateInvoicing { get; set; }
        public long SysaccountingPeriodValidationId { get; set; }
        public bool UseNewVatrulesForEsd { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public bool UsePostponedVatrules { get; set; }

        public virtual SysaccountingPeriodValidation SysaccountingPeriodValidation { get; set; } = null!;
    }
}
