using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSubscriptionCriterion
    {
        public long SiconSubscriptionCriteriaId { get; set; }
        public long SiconSubscriptionId { get; set; }
        public string FieldName { get; set; } = null!;
        public string? CriteriaValue { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
