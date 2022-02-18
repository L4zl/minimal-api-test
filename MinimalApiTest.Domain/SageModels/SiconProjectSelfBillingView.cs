using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectSelfBillingView
    {
        public long SiJcTrnId { get; set; }
        public DateTime? TransDate { get; set; }
        public long? SiJcEmpId { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public decimal? ActualQuantity { get; set; }
        public int RateIndex { get; set; }
        public string RateDescription { get; set; } = null!;
        public bool IsFixedRate { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal FixedRate { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? SysaccountingPeriodId { get; set; }
        public short? AccountingPeriod { get; set; }
        public short? AccountingPeriodYear { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcchdId { get; set; }
        public long? PhrateId { get; set; }
        public long? PrateId { get; set; }
        public long? HrateId { get; set; }
    }
}
