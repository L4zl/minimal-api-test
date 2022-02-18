using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderSerialNumber
    {
        public long SiWorksOrderSerialNumberId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public string? IdentificationNo { get; set; }
        public bool? IsUsed { get; set; }
        public DateTime? DateBookedIn { get; set; }
        public long? TraceableItem { get; set; }
        public long? SiWorksOrderFinishedItem { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityBooked { get; set; }
        public bool AddedAsDuplicate { get; set; }
    }
}
