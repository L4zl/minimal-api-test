using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAllocationLine
    {
        public long SiconAllocationLineId { get; set; }
        public long AllocationId { get; set; }
        public long? TypeId { get; set; }
        public long? ForeignId { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseItemId { get; set; }
        public string? Reference { get; set; }
        public string? SecondRef { get; set; }
        public int? UserId { get; set; }
        public string? Username { get; set; }
        public DateTime? RequiredDate { get; set; }
    }
}
