using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WarehouseType
    {
        public WarehouseType()
        {
            Warehouses = new HashSet<Warehouse>();
        }

        public long WarehouseTypeId { get; set; }
        public string WarehouseTypeName { get; set; } = null!;

        public virtual ICollection<Warehouse> Warehouses { get; set; }
    }
}
