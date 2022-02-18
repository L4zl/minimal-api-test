using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmcontractBillView
    {
        public long SiconContractBillId { get; set; }
        public long SiconContractLineId { get; set; }
        public DateTime? ForecastFrom { get; set; }
        public DateTime? ForecastTo { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? UnitOrderValue { get; set; }
        public decimal? TotalOrderNetValue { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
