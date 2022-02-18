using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabcachedPickListItem
    {
        public long SiconWabcachedPickListItemId { get; set; }
        public long OrderId { get; set; }
        public long OrderLineId { get; set; }
        public string? JsonpickListItem { get; set; }
        public decimal Quantity { get; set; }
        public long ItemId { get; set; }
        public long BinItemId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public bool? IsPicked { get; set; }
        public bool? IsPacked { get; set; }
        public int LineTypeId { get; set; }
        public long? BoxItemId { get; set; }
        public long? PackageId { get; set; }
        public int? ShippingContainerType { get; set; }
        public string? PackageNumber { get; set; }
    }
}
