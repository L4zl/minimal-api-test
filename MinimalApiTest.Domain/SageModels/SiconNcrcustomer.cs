using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconNcrcustomer
    {
        public long SiconNcrcustomerId { get; set; }
        public long? CustomerId { get; set; }
        public long? SalesOrderId { get; set; }
        public string SiconNcrcaseId { get; set; } = null!;
        public string? DiscrepancyExplanation { get; set; }
        public long? InspectedBy { get; set; }
        public DateTime? InspectedDate { get; set; }
        public long? RejectType { get; set; }
        public long? ResponsibleTeam { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? RejectedQuantity { get; set; }
        public string? ActionsTaken { get; set; }
        public DateTime? ActionsTakenDate { get; set; }
        public string? BatchNumber { get; set; }
        public string? Rcawhy1 { get; set; }
        public string? Rcawhy2 { get; set; }
        public string? Rcawhy3 { get; set; }
        public string? Rcawhy4 { get; set; }
        public string? Rcawhy5 { get; set; }
    }
}
