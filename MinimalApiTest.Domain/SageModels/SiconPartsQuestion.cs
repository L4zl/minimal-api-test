using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPartsQuestion
    {
        public long SiconPartsQuestionId { get; set; }
        public long? ProductGroupId { get; set; }
        public long? StockItemId { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public string? QuestionText { get; set; }
        public bool? Mandatory { get; set; }
        public int? OrderVal { get; set; }
        public bool? Removed { get; set; }
        public bool? SelectMany { get; set; }
        public string? DefaultAnswer { get; set; }
        public bool? UseLimits { get; set; }
        public decimal? LowerLimit { get; set; }
        public decimal? UpperLimit { get; set; }
        public bool? UseWarnings { get; set; }
        public decimal? LowerWarning { get; set; }
        public decimal? UpperWarning { get; set; }
        public long? AnswerTypeId { get; set; }
        public string? LowerWarningText { get; set; }
        public string? UpperWarningText { get; set; }
        public string? Unit { get; set; }
        public bool? HideFromCustomer { get; set; }
        public bool? UsesReportReplacementText { get; set; }
    }
}
