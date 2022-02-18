using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistContainerLineView
    {
        public long SiconDistContainerPolinkId { get; set; }
        public decimal? QuantityForContainer { get; set; }
        public long SiconDistContainerId { get; set; }
        public string? InternalContainerNumber { get; set; }
        public string? ActualContainerNumber { get; set; }
        public string? TrackingStatus { get; set; }
        public long PoporderReturnLineId { get; set; }
        public string ItemCode { get; set; } = null!;
        public long PoporderReturnId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public DateTime? DeliveryDate { get; set; }
    }
}
