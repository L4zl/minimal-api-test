using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystranDateValidationType
    {
        public SystranDateValidationType()
        {
            SystranDateValidationTerms = new HashSet<SystranDateValidationTerm>();
        }

        public long SystranDateValidationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SystranDateValidationTerm> SystranDateValidationTerms { get; set; }
    }
}
