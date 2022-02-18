using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ProductGroupUnit
    {
        public long ProductGroupUnitId { get; set; }
        public long ProductGroupId { get; set; }
        public long UnitId { get; set; }
        public long UnitOfMeasureTypeId { get; set; }
        public decimal MultipleOfBaseUnit { get; set; }
        public bool UseOwnPrice { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal UnitPrecision { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ProductGroup ProductGroup { get; set; } = null!;
        public virtual Unit Unit { get; set; } = null!;
        public virtual UnitOfMeasureType UnitOfMeasureType { get; set; } = null!;
    }
}
