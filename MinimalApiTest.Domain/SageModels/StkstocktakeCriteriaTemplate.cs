using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkstocktakeCriteriaTemplate
    {
        public long StkstocktakeCriteriaTemplateId { get; set; }
        public string CriteriaName { get; set; } = null!;
        public string Criteria { get; set; } = null!;
    }
}
