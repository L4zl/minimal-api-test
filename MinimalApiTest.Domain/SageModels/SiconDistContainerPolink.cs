using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistContainerPolink
    {
        public long SiconDistContainerPolinkId { get; set; }
        public long? SiconDistContainerId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public decimal? QuantityForContainer { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public bool Completed { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
