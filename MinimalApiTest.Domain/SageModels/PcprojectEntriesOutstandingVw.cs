using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectEntriesOutstandingVw
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
        public string InQueryIndicator { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public decimal GoodsAmountInBaseCurrency { get; set; }
        public decimal UpliftValueInBaseCurrency { get; set; }
        public decimal ChargeRateInBaseCurrency { get; set; }
        public decimal CostRateInBaseCurrency { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ProjectCode { get; set; } = null!;
        public int IsNegative { get; set; }
        public decimal? TotalBaseCurrency { get; set; }
        public decimal? TotalDocumentCurrency { get; set; }
        public decimal? QuantityBilled { get; set; }
        public long PcprojectEntryDescriptorId { get; set; }
        public string? TransactionType { get; set; }
        public long PctopLevelParentId { get; set; }
        public long ParentProjectId { get; set; }
        public bool IsWiptransaction { get; set; }
        public decimal WipvalueInBaseCurrency { get; set; }
        public string? FinalisationBillNumber { get; set; }
        public DateTime? FinalisationBillDate { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? StockItemCode { get; set; }
        public string? HumanResourceName { get; set; }
        public string NominalAccountNumber { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
    }
}
