using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmopporHierarchyView
    {
        public long SiconTcmtaskId { get; set; }
        public string Description { get; set; } = null!;
        public string CompletionDescription { get; set; } = null!;
        public long? SiconTcmmoduleTypeId { get; set; }
        public string ModuleTypeName { get; set; } = null!;
        public string ModuleTypeDescription { get; set; } = null!;
        public long? ModuleTypeForeignId { get; set; }
        public string Summary { get; set; } = null!;
        public bool IsComplete { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime DueDateTime { get; set; }
        public DateTime? CompletedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public long? SiconContactPersonId { get; set; }
        public string ContactPersonName { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public long? SiconTcmtaskTypeId { get; set; }
        public string TaskTypeName { get; set; } = null!;
        public string TaskTypeDescription { get; set; } = null!;
        public long? SiconTcmuserId { get; set; }
        public string TcmuserLogonName { get; set; } = null!;
        public string TcmuserName { get; set; } = null!;
        public long SiconTcmtaskHierarchyId { get; set; }
        public long? ImmediateParentTaskId { get; set; }
        public long? TopLevelTaskId { get; set; }
        public long? ClassificationId { get; set; }
        public string ClassificationDescription { get; set; } = null!;
        public long? OutcomeId { get; set; }
        public string OutcomeDescription { get; set; } = null!;
        public short CompletePercentage { get; set; }
        public short ProbabilityPercentage { get; set; }
        public decimal ForecastValue { get; set; }
        public decimal RevenueValue { get; set; }
    }
}
