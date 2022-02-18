using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconForecastView
    {
        public DateTime? ForecastFrom { get; set; }
        public DateTime? ForecastTo { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? TotalOrderNetValue { get; set; }
        public string Type { get; set; } = null!;
        public string? Month { get; set; }
        public decimal? RemainingToBill { get; set; }
        public decimal? InvoicedToDate { get; set; }
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string? Description { get; set; }
        public string Contact { get; set; } = null!;
        public string? DocumentNo { get; set; }
    }
}
