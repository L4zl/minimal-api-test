using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHminspectionHistory
    {
        public long SiconHminspectionHistoryId { get; set; }
        public long FixedAssetId { get; set; }
        public DateTime? DateOfExamination { get; set; }
        public long? ExaminationTypeId { get; set; }
        public string? Details { get; set; }
        public string? ExaminedBy { get; set; }
        public long? SiconHmorderId { get; set; }
        public bool? Passed { get; set; }
    }
}
