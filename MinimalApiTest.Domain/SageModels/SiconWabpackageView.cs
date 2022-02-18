using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabpackageView
    {
        public string BinName { get; set; } = null!;
        public long SiconWabboxItemId { get; set; }
        public decimal Quantity { get; set; }
        public long? TraceableItemId { get; set; }
        public long? BinItemId { get; set; }
        public long? ItemId { get; set; }
        public long? PickAllocationId { get; set; }
        public long? ForeignId { get; set; }
        public string? ToteNumber { get; set; }
        public long? ToteId { get; set; }
        public string? BagNumber { get; set; }
        public long? BagId { get; set; }
        public string? BoxNumber { get; set; }
        public long? BoxId { get; set; }
        public string? PalletNumber { get; set; }
        public long? PalletId { get; set; }
        public string? VehicleNumber { get; set; }
        public long? VehicleId { get; set; }
        public string? ContainerNumber { get; set; }
        public long? ContainerId { get; set; }
        public long? TopPackageId { get; set; }
        public string? TopPackageNumber { get; set; }
        public int? TopPackageType { get; set; }
        public long? SopdespatchReceiptId { get; set; }
        public long? SoporderReturnId { get; set; }
    }
}
