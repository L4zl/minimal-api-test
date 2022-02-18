using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcdesktopBasicView
    {
        public long? Id { get; set; }
        public long Sijcjobid { get; set; }
        public string? Jobnumber { get; set; }
        public string? Description { get; set; }
        public string? Jcstatus { get; set; }
        public decimal? Percentagecomplete { get; set; }
        public string? Jobmanager { get; set; }
        public long? TraderAccountId { get; set; }
        public string CustomerReference { get; set; } = null!;
        public string? Customername { get; set; }
        public string? Analysistype1 { get; set; }
        public string? Analysistype2 { get; set; }
        public string? Analysistype3 { get; set; }
        public string? Analysistype4 { get; set; }
        public string? Analysistype5 { get; set; }
        public string? AnalysisType6 { get; set; }
        public string? AnalysisType7 { get; set; }
        public DateTime? Plancompdate { get; set; }
        public string? LastC2cbyUser { get; set; }
        public DateTime? LastC2cdateTime { get; set; }
        public bool? ExcludeFromJobList { get; set; }
        public DateTime? ActualCompDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? JobCreatedDateTime { get; set; }
        public string PaidStatus { get; set; } = null!;
    }
}
