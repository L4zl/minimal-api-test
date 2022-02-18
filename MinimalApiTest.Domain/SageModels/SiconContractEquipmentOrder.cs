using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractEquipmentOrder
    {
        public long SiconContractEquipmentOrderId { get; set; }
        public long SiconContractLineId { get; set; }
        public long? DefaultWarehouseId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderStatus { get; set; } = null!;
    }
}
