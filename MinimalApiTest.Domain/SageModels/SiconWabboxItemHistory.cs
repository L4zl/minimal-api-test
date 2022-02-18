using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabboxItemHistory
    {
        public long SiconWabboxItemHistoryId { get; set; }
        public long? SiconWabboxItemId { get; set; }
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
        public string BoxIdentificationNo { get; set; } = null!;
        public long? BoxSoporderReturnId { get; set; }
        public long? BoxSopdespatchReceiptId { get; set; }
        public int BoxShippingTypeId { get; set; }
        public string? BoxSecondReference { get; set; }
        public bool? BoxIsLabelPrinted { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
