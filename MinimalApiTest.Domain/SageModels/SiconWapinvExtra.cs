using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWapinvExtra
    {
        public long SiconWapinvExtraId { get; set; }
        public int Urn { get; set; }
        public string Wapnotes { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public int ApproverId { get; set; }
        public int BusinessUnitId { get; set; }
        public bool HasVariance { get; set; }
        public string VarianceBreakdown { get; set; } = null!;
        public string VarianceComment { get; set; } = null!;
        public bool Urgent { get; set; }
        public int Approver2Id { get; set; }
        public int Approver3Id { get; set; }
        public int Approver4Id { get; set; }
        public int Approver5Id { get; set; }
        public int Approver6Id { get; set; }
        public int Approver7Id { get; set; }
        public int Approver8Id { get; set; }
        public int Approver9Id { get; set; }
        public int Approver10Id { get; set; }
    }
}
