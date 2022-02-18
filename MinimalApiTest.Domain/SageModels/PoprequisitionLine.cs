using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoprequisitionLine
    {
        public PoprequisitionLine()
        {
            PoprequisitionFulfilmentLines = new HashSet<PoprequisitionFulfilmentLine>();
        }

        public long PoprequisitionLineId { get; set; }
        public long PoprequisitionId { get; set; }
        public long PoprequisitionStatusId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? SupplierCode { get; set; }
        public string? SupplierName { get; set; }
        public string ItemCode { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string WarehouseName { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal QuantityToFulfil { get; set; }
        public decimal QuantityFulfilled { get; set; }
        public string TaxRateName { get; set; } = null!;
        public decimal TaxRate { get; set; }
        public string NominalAccountName { get; set; } = null!;
        public string NominalAccountRef { get; set; } = null!;
        public string NominalCostCentre { get; set; } = null!;
        public string NominalDepartment { get; set; } = null!;
        public string? BuyingUnitDescription { get; set; }
        public decimal UnitBuyingPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal ExchangeRate { get; set; }
        public string CurrencySymbol { get; set; } = null!;
        public long? AuthoriserUserId { get; set; }
        public string? AuthoriserUserName { get; set; }
        public DateTime? AuthorisedDate { get; set; }
        public string AuthoriserComment { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long? NlreportCategoryBudgetId { get; set; }

        public virtual NlreportCategoryBudget? NlreportCategoryBudget { get; set; }
        public virtual Poprequisition Poprequisition { get; set; } = null!;
        public virtual PoprequisitionStatus PoprequisitionStatus { get; set; } = null!;
        public virtual ICollection<PoprequisitionFulfilmentLine> PoprequisitionFulfilmentLines { get; set; }
    }
}
