using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmaudienceCriterion
    {
        public long SiconCrmaudienceCriteriaId { get; set; }
        public long SiconCrmaudienceId { get; set; }
        public string FilterOperator { get; set; } = null!;
        public string LogicalOperator { get; set; } = null!;
        public string CriteraValue { get; set; } = null!;
        public long? ParentAudienceCriteriaId { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
        public string CriteriaType { get; set; } = null!;
        public string FieldName { get; set; } = null!;
        public string FieldValue { get; set; } = null!;
    }
}
