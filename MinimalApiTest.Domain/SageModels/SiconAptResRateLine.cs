using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAptResRateLine
    {
        public long SiconAptResRateLineId { get; set; }
        public long SiconAppointmentResourceId { get; set; }
        public long SiJcTrnId { get; set; }
        public int? RateNumber { get; set; }
        public long? SiSmaptResTimeBookingId { get; set; }
        public int? BillingPlan { get; set; }
        public decimal? ChargeRateOverride { get; set; }
        public long? ServiceStockItemId { get; set; }
    }
}
