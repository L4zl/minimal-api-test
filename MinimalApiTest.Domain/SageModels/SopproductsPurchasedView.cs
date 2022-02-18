using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopproductsPurchasedView
    {
        public long MmssoppTransactionHistoryId { get; set; }
        public long MmssoppTransactionTypeId { get; set; }
        public DateTime MmssoppTransactionDate { get; set; }
        public double? MmssoppQuantity { get; set; }
        public string? MmssoppCode { get; set; }
        public string MmssoppName { get; set; } = null!;
        public double? MmssoppIssueValue { get; set; }
        public DateTime? MmssoppPostedDate { get; set; }
        public string MmssoppSourceAreaReference { get; set; } = null!;
        public string? MmssoppStockItemId { get; set; }
        public string? MmssoppStockItemStatusName { get; set; }
        public double? MmssoppUnitCostPrice { get; set; }
        public double? MmssoppUnitIssuePrice { get; set; }
        public double? MmssoppUnitDiscountValue { get; set; }
        public double? MmssoppTotalOrderDiscount { get; set; }
        public double? MmssoppCostValue { get; set; }
    }
}
