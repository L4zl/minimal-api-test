using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderAvailability
    {
        public long SiWorksOrderAvailabilityId { get; set; }
        public long? BomcostItemId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? SiWorksOrderDeptId { get; set; }
        public decimal? Week1Hours { get; set; }
        public decimal? Week2Hours { get; set; }
        public decimal? Week3Hours { get; set; }
        public decimal? DefaultDailyAvailability { get; set; }
    }
}
