using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmaddLabRateLine
    {
        public long SiSmaddLabRateLineId { get; set; }
        public long SiSmcaseAdditionalLabourId { get; set; }
        public long SiJcTrnId { get; set; }
        public int? RateNumber { get; set; }
        public int? BillingPlan { get; set; }
        public decimal? ChargeRateOverride { get; set; }
        public long? ServiceStockItemId { get; set; }
    }
}
