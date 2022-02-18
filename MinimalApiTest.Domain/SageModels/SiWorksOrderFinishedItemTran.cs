using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderFinishedItemTran
    {
        public long SiWorksOrderFinishedItemTranId { get; set; }
        public long SiWorksOrderFinishedItemId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Cost { get; set; }
        public string? Detail { get; set; }
        public long? TransactionHistoryId { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Updateduser { get; set; }
        public bool? UnconfirmedCost { get; set; }
        public decimal? ScrapQuantity { get; set; }
        public string? ScrapReason { get; set; }
    }
}
