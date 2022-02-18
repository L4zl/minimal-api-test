using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconComponentWarehouse
    {
        public long SiconComponentWarehouseId { get; set; }
        public long? ParentWarehouseId { get; set; }
        public long? ChildWarehouseId { get; set; }
        public bool? ChildIsPurchasingWarehouse { get; set; }
        public bool? ChildIsProductionWarehouse { get; set; }
        public int? Priority { get; set; }
    }
}
