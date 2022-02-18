using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class UnitOfMeasureType
    {
        public UnitOfMeasureType()
        {
            ProductGroupUnits = new HashSet<ProductGroupUnit>();
            StockItemUnitUomtypes = new HashSet<StockItemUnitUomtype>();
        }

        public long UnitOfMeasureTypeId { get; set; }
        public string UnitOfMeasureTypeName { get; set; } = null!;

        public virtual ICollection<ProductGroupUnit> ProductGroupUnits { get; set; }
        public virtual ICollection<StockItemUnitUomtype> StockItemUnitUomtypes { get; set; }
    }
}
