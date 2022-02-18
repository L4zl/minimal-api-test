using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprequisitionFulfilmentLine
    {
        public long PoprequisitionFulfilmentLineId { get; set; }
        public long PoprequisitionLineId { get; set; }
        public long LinkedItemId { get; set; }
        public string LinkedReference { get; set; } = null!;
        public long PoprequisitionFulfilmentLineTypeId { get; set; }
        public long? SupplierId { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public long? WarehouseItemId { get; set; }
        public string WarehouseName { get; set; } = null!;
        public decimal Quantity { get; set; }
        public string NominalAccountName { get; set; } = null!;
        public string NominalAccountRef { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public decimal UnitBuyingPrice { get; set; }
        public decimal NetValue { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long? WarehouseId { get; set; }

        public virtual PoprequisitionFulfilmentLineType PoprequisitionFulfilmentLineType { get; set; } = null!;
        public virtual PoprequisitionLine PoprequisitionLine { get; set; } = null!;
        public virtual PlsupplierAccount? Supplier { get; set; }
        public virtual Warehouse? Warehouse { get; set; }
        public virtual WarehouseItem? WarehouseItem { get; set; }
    }
}
