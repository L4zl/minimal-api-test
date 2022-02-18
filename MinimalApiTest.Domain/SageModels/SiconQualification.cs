using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconQualification
    {
        public long SiJcQualificationId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUser { get; set; }
    }
}
