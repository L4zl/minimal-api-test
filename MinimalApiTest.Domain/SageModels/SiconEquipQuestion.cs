using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipQuestion
    {
        public long SiconEquipQuestionId { get; set; }
        public long? ProductGroupId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? StockItemId { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public long? SiSmserviceIntervalTypeId { get; set; }
        public int? Warranty { get; set; }
        public string? QuestionText { get; set; }
        public bool? Mandatory { get; set; }
        public int? Order { get; set; }
        public bool Removed { get; set; }
        public bool? SelectMany { get; set; }
        public string? DefaultAnswer { get; set; }
        public bool? UsesReportReplacementText { get; set; }
        public bool? UseLimits { get; set; }
        public decimal? LowerLimit { get; set; }
        public decimal? UpperLimit { get; set; }
        public bool? UseWarnings { get; set; }
        public decimal? LowerWarning { get; set; }
        public string? LowerWarningText { get; set; }
        public decimal? UpperWarning { get; set; }
        public string? UpperWarningText { get; set; }
        public int? AnswerTypeId { get; set; }
        public string? Unit { get; set; }
        public bool? HideFromCustomer { get; set; }
    }
}
