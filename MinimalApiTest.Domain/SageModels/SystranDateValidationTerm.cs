using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystranDateValidationTerm
    {
        public long SystranDateValidationTermsId { get; set; }
        public long TranDateValidationTypeId { get; set; }
        public long ClosedPeriodClassificationId { get; set; }
        public long FuturePeriodClassificationId { get; set; }
        public long FutureYearClassificationId { get; set; }
        public long PreviousYearClassificationId { get; set; }
        public int PostDaysAcceptable { get; set; }
        public int PostDaysNormal { get; set; }
        public int PreDaysAcceptable { get; set; }
        public int PreDaysNormal { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystranDateValidationClass ClosedPeriodClassification { get; set; } = null!;
        public virtual SystranDateValidationClass FuturePeriodClassification { get; set; } = null!;
        public virtual SystranDateValidationClass FutureYearClassification { get; set; } = null!;
        public virtual SystranDateValidationClass PreviousYearClassification { get; set; } = null!;
        public virtual SystranDateValidationType TranDateValidationType { get; set; } = null!;
    }
}
