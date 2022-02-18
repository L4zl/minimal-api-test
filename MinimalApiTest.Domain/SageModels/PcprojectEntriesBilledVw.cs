using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectEntriesBilledVw
    {
        public long PcprojectItemId { get; set; }
        public string Code { get; set; } = null!;
        public long PccostItemId { get; set; }
        public long CostItemTypeId { get; set; }
        public long PcprojectEntryId { get; set; }
        public decimal Quantity { get; set; }
        public long? UnitOfMeasure { get; set; }
        public decimal RevenueRateInBaseCurrency { get; set; }
        public decimal ValueToBillInBaseCurrency { get; set; }
        public decimal GoodsAmountInBaseCurrency { get; set; }
        public decimal UpliftValueInBaseCurrency { get; set; }
        public string InQueryIndicator { get; set; } = null!;
        public DateTime? TransactionDate { get; set; }
        public string ProjectCode { get; set; } = null!;
        public decimal PostingQuantity { get; set; }
        public decimal AmountBaseCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal AmountDocumentCurrency { get; set; }
        public long PcprojectEntryPostingId { get; set; }
        public string? TransactionType { get; set; }
        public long ParentProjectId { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? StockItemCode { get; set; }
        public string? HumanResourceName { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
    }
}
