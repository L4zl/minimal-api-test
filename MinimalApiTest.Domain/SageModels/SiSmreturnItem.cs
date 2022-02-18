using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmreturnItem
    {
        public long SiSmreturnItemId { get; set; }
        public long? ItemId { get; set; }
        public long? SiconEquipmentId { get; set; }
        public long? SiJcEmpId { get; set; }
        public long? SiSmcaseId { get; set; }
        public int? TypeId { get; set; }
        public int? StatusId { get; set; }
        public string? IdentificationNo { get; set; }
        public long? SiSmreturnSubStatusId { get; set; }
        public string? Description { get; set; }
        public long? SiSmstockAvailableForCaseId { get; set; }
        public string? Notes { get; set; }
        public decimal? Quantity { get; set; }
        public long? IssueHistoryId { get; set; }
        public int? PartQualityStatusId { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public long? IssueReturnHistoryId { get; set; }
        public long? WriteOffHistoryId { get; set; }
    }
}
