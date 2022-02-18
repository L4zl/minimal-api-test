using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabdynamicStocktakeItem
    {
        public long SiconWabdynamicStocktakeItemId { get; set; }
        public long SiconWabdynamicStocktakeId { get; set; }
        public long? BinItemId { get; set; }
        public long? AddTransactionHistoryId { get; set; }
        public long? RemoveTransactionHistoryId { get; set; }
        public decimal ActualQuantityCounted { get; set; }
        public decimal PreviousQuantityInSage { get; set; }
        public decimal QuantityAdded { get; set; }
        public decimal QuantityRemoved { get; set; }
        public DateTime? DateTimeCounted { get; set; }
        public bool? IsCounted { get; set; }
        public bool? Recount { get; set; }
        public string? BinName { get; set; }
        public string? CountedByUserName { get; set; }
    }
}
