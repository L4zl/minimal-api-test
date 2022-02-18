using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseStockItem
    {
        public long SiSmcaseStockItemId { get; set; }
        public long? ItemId { get; set; }
        public long? SiSmcaseId { get; set; }
        public long? BinItemId { get; set; }
        public string? Description { get; set; }
        public long? TypeId { get; set; }
        public long? AllocationId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Issued { get; set; }
        public decimal? Invoiced { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public decimal? UnitCostPrice { get; set; }
        public long? SiconAppointmentId { get; set; }
        public long? SiSmstockAvailableForCaseId { get; set; }
        public long? SiJcTrnId { get; set; }
        public long? SiconEquipmentId { get; set; }
        public bool? IssueNominalAdjusted { get; set; }
        public long? FreeTextPoplineId { get; set; }
        public long? RevenueSiJcTrnId { get; set; }
        public int? BillingPlan { get; set; }
        public string? BillingNote { get; set; }
        public long? SupplierId { get; set; }
        public bool? RaisePo { get; set; }
    }
}
