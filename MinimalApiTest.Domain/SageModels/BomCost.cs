using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomCost
    {
        public long BomCostId { get; set; }
        public long BomCostSessionId { get; set; }
        public long BomCostTypeId { get; set; }
        public long? MsmCostHeadingId { get; set; }
        public long MsmCostHeadingTypeId { get; set; }
        public string CostHeadingName { get; set; } = null!;
        public string OperationReference { get; set; } = null!;
        public string OperationDescription { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal UnitCost { get; set; }
        public string? StockUnit { get; set; }
        public decimal? StockQuantity { get; set; }
        public string Units { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal Cost { get; set; }
        public decimal Overhead { get; set; }
        public decimal Markup { get; set; }
        public decimal OverheadPercentage { get; set; }
        public decimal MarkupPercentage { get; set; }
        public decimal TotalCost { get; set; }
        public decimal Profit { get; set; }
        public decimal MarginPercentage { get; set; }
        public long? SubassemblyCostSessionId { get; set; }
        public bool? Consumed { get; set; }
        public long? OpOperationPhaseId { get; set; }
        public bool FixedCost { get; set; }
        public bool? CurrencyConversionPerformed { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? ForeignCurrencyName { get; set; }
        public string? ForeignCurrencySymbol { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomCostSession BomCostSession { get; set; } = null!;
        public virtual BomCostType BomCostType { get; set; } = null!;
        public virtual MsmCostHeading? MsmCostHeading { get; set; }
        public virtual MsmCostHeadingType MsmCostHeadingType { get; set; } = null!;
        public virtual OpOperationPhase? OpOperationPhase { get; set; }
    }
}
