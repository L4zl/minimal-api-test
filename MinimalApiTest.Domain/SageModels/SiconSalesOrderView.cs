using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrderView
    {
        public long SiconSalesOrderId { get; set; }
        public string? DocumentNo { get; set; }
        public string? JobNumber { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerReference { get; set; } = null!;
        public string DocumentStatus { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public decimal TotalOrderValue { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? AnalysisCode6 { get; set; }
        public string? AnalysisCode7 { get; set; }
        public string? AnalysisCode8 { get; set; }
        public string? AnalysisCode9 { get; set; }
        public string? AnalysisCode10 { get; set; }
        public string? AnalysisCode11 { get; set; }
        public string? AnalysisCode12 { get; set; }
        public string? AnalysisCode13 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        public string? QuoteStatus { get; set; }
        public decimal? QuoteProbability { get; set; }
        public DateTime? EstimatedOrderDate { get; set; }
    }
}
