using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopauthRuleView
    {
        public long PopauthRuleId { get; set; }
        public string? Authority { get; set; }
        public decimal GreaterThanOrEqualValue { get; set; }
        public decimal LessThanValue { get; set; }
        public long AuthorisationGroup { get; set; }
        public string? OrderOriginator { get; set; }
        public bool? Isolated { get; set; }
    }
}
