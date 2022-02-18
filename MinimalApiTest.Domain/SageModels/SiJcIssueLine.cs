using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcIssueLine
    {
        public long SiJcIssueLineId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Cost { get; set; }
        public long? SiJcChdId { get; set; }
        public string? Narrative { get; set; }
        public DateTime? Date { get; set; }
        public long? BinItemId { get; set; }
        public long? InternalAreaId { get; set; }
        public decimal? Quantity { get; set; }
        public string? IdentificationNo { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? SijcphaseId { get; set; }
        public long? SijcstageId { get; set; }
        public long? SijcsubStageId { get; set; }
        public long? SijcvariationId { get; set; }
        public long? SioperationId { get; set; }
        public long? SiJcEmpId { get; set; }
        public string? Reference { get; set; }
    }
}
