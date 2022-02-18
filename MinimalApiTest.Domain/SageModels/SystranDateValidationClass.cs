using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystranDateValidationClass
    {
        public SystranDateValidationClass()
        {
            SystranDateValidationTermClosedPeriodClassifications = new HashSet<SystranDateValidationTerm>();
            SystranDateValidationTermFuturePeriodClassifications = new HashSet<SystranDateValidationTerm>();
            SystranDateValidationTermFutureYearClassifications = new HashSet<SystranDateValidationTerm>();
            SystranDateValidationTermPreviousYearClassifications = new HashSet<SystranDateValidationTerm>();
        }

        public long SystranDateValidationClassId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SystranDateValidationTerm> SystranDateValidationTermClosedPeriodClassifications { get; set; }
        public virtual ICollection<SystranDateValidationTerm> SystranDateValidationTermFuturePeriodClassifications { get; set; }
        public virtual ICollection<SystranDateValidationTerm> SystranDateValidationTermFutureYearClassifications { get; set; }
        public virtual ICollection<SystranDateValidationTerm> SystranDateValidationTermPreviousYearClassifications { get; set; }
    }
}
