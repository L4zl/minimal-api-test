using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractEquipOrderLine
    {
        public long SiconContractEquipOrderLineId { get; set; }
        public long SiconContractEquipmentOrderId { get; set; }
        public long ItemId { get; set; }
        public long? WarehouseItemId { get; set; }
        public string? Description { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Allocated { get; set; }
        public decimal? Despatched { get; set; }
        public short? GroupNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool? IsWorksOrderCreated { get; set; }
        public int? LineNumber { get; set; }
    }
}
