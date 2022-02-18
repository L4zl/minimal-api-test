using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StitemLocationsView
    {
        public string? MmsstlCode { get; set; }
        public string? MmsstlWarehouseName { get; set; }
        public string? MmsstlWarehouseDescription { get; set; }
        public long MmsstlItemId { get; set; }
        public double? MmsstlQuantityOnOrder { get; set; }
        public double? MmsstlQuantityInStock { get; set; }
        public double? MmsstlQuantityAllocated { get; set; }
        public double? MmsstlFreeStock { get; set; }
    }
}
