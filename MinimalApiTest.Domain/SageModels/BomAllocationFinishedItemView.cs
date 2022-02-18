using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomAllocationFinishedItemView
    {
        public long? BomAllocationId { get; set; }
        public long WopOrderId { get; set; }
        public string StockCode { get; set; } = null!;
        public long MseStockItemId { get; set; }
        public string ReferenceVersion { get; set; } = null!;
        public string BuildPackageReference { get; set; } = null!;
        public decimal? QuantityOutstanding { get; set; }
        public decimal OriginalQuantity { get; set; }
        public string UnitOfMeasure { get; set; } = null!;
        public long StockItemId { get; set; }
        public int AllocationHasModifications { get; set; }
        public bool OrderHasModifications { get; set; }
    }
}
