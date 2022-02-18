using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistContainerView
    {
        public long SiconDistContainerId { get; set; }
        public string? InternalContainerNumber { get; set; }
        public string? ActualContainerNumber { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
    }
}
