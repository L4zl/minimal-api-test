using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconNcrsupplier
    {
        public long SiconNcrsupplierId { get; set; }
        public long? SupplierId { get; set; }
        public long? PurchaseOrderId { get; set; }
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
        public string? RootCauseAnalysis { get; set; }
    }
}
