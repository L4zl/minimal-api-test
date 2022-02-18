using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabboxItem
    {
        public long SiconWabboxItemId { get; set; }
        public long? ForeignId { get; set; }
        public decimal Quantity { get; set; }
        public long? TraceableItemId { get; set; }
        public int BoxTypeId { get; set; }
        public long? PickAllocationId { get; set; }
        public long? BinItemId { get; set; }
        public long? ItemId { get; set; }
        public long? BagId { get; set; }
        public long? BoxId { get; set; }
        public long? PalletId { get; set; }
        public long? ContainerId { get; set; }
        public long? VehicleId { get; set; }
        public long? ToteId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
