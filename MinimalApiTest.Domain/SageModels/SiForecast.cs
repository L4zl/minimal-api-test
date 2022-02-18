using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiForecast
    {
        public long? ForecastId { get; set; }
        public string? StockItemCode { get; set; }
        public string? ProductGroup { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? ForecastSalesQty { get; set; }
        public decimal? PreviousYearQty { get; set; }
        public decimal? LastYearQty { get; set; }
        public decimal? MinReorderQty { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
