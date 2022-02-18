using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmaptLabelChargeRate
    {
        public long SiSmaptLabelChargeRateId { get; set; }
        public long? SiSmappointmentLabelId { get; set; }
        public bool? Enabled { get; set; }
        public long? ChargeRateId { get; set; }
        public long? ServiceStockItemId { get; set; }
    }
}
