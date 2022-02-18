using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmappointmentLabel
    {
        public long SiSmappointmentLabelId { get; set; }
        public long SiconAppointmentLabelId { get; set; }
        public bool? IsEnabledForSm { get; set; }
        public string? Type { get; set; }
        public long? ServiceStockItem { get; set; }
        public int? ChargeType { get; set; }
        public decimal? FlatRateValue { get; set; }
        public long? DefaultRateOverride { get; set; }
    }
}
