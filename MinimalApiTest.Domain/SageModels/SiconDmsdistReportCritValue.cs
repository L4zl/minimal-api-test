using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdistReportCritValue
    {
        public long SiconDmsdistReportCritValueId { get; set; }
        public long SiconDmsdistributionReportId { get; set; }
        public long SiconDmsdistributionCriteriaId { get; set; }
        public string FieldName { get; set; } = null!;
        public string FieldFriendlyName { get; set; } = null!;
        public string FilterOperator { get; set; } = null!;
        public string CriteriaValue { get; set; } = null!;
        public string HeaderFilename { get; set; } = null!;
        public string LetterheadFilename { get; set; } = null!;
        public string TermsAndConditionsFilename { get; set; } = null!;
        public short Sequence { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
