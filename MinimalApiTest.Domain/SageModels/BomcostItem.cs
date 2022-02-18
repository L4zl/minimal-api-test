using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomcostItem
    {
        public BomcostItem()
        {
            BomcostItemUnits = new HashSet<BomcostItemUnit>();
            BomlineCheckedOuts = new HashSet<BomlineCheckedOut>();
            Bomlines = new HashSet<Bomline>();
        }

        public long BomcostItemId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long BomcostTypeId { get; set; }
        public decimal ChargeRate { get; set; }
        public long BaseUnitId { get; set; }
        public decimal OhallocationRatio { get; set; }
        public string? NominalAccountRef { get; set; }
        public string? NominalCostCentre { get; set; }
        public string? NominalDepartment { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Bomunit BaseUnit { get; set; } = null!;
        public virtual Old200BomcostType BomcostType { get; set; } = null!;
        public virtual ICollection<BomcostItemUnit> BomcostItemUnits { get; set; }
        public virtual ICollection<BomlineCheckedOut> BomlineCheckedOuts { get; set; }
        public virtual ICollection<Bomline> Bomlines { get; set; }
    }
}
