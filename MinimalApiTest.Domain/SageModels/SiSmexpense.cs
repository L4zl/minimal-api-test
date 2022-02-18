using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmexpense
    {
        public long SiSmexpenseId { get; set; }
        public long? SiSmexpenseTypeId { get; set; }
        public long? SiSmcaseId { get; set; }
        public long? SiJcempId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SiJcTrnId { get; set; }
        public long? RevenueSiJcTrnId { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Quantity { get; set; }
        public int? ExpenseStatus { get; set; }
        public int? BillingPlan { get; set; }
        public long? ItemId { get; set; }
        public decimal? ApprovedCost { get; set; }
        public decimal? ExpectedCost { get; set; }
        public long? SupplierId { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactTel { get; set; }
        public DateTime? RequestedDate { get; set; }
        public decimal? UnitSellingPrice { get; set; }
        public bool? ForceOverrideSellingPrice { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? SiSmstockAvailableForCaseId { get; set; }
        public long? SiSmcaseStockItemId { get; set; }
    }
}
