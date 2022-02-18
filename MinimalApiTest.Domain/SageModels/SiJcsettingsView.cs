using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcsettingsView
    {
        public string? DataVersion { get; set; }
        public string? AutoCreateBudgetRecords { get; set; }
        public string? ShowConstuctionLines { get; set; }
        public string? AutoCreateJobforSop { get; set; }
        public string? AutoNextJobNumber { get; set; }
        public string? AutoIssueAfterGoodsReceived { get; set; }
        public string? DefaultInternalAreaOnRapidIssueScreen { get; set; }
        public string? JobLabelOverride { get; set; }
        public string? PhaseLabelOverride { get; set; }
        public string? StageLabelOverride { get; set; }
        public string? ActivityLabelOverride { get; set; }
        public string? SettingsVersion { get; set; }
        public string? WipvalueFormat { get; set; }
        public string? WipquantityFormat { get; set; }
        public string? WiphideCheckBoxes { get; set; }
        public string? UpdatePoplinesAfterReceiptReturn { get; set; }
        public string? UpdatePopactualsOn { get; set; }
        public string? StaticSoplineNumberStoreLocation { get; set; }
        public string? SopincludeCosinStock { get; set; }
        public string? JobStructuresEnabled { get; set; }
        public string? IssueAfterGoodsReceivedAtPopcosts { get; set; }
        public string? EnableHoursColumn { get; set; }
        public string? JobPhasesEnabled { get; set; }
        public string? JobStagesEnabled { get; set; }
        public string? JobActivitiesEnabled { get; set; }
        public string? CostToCompleteMode { get; set; }
        public string? PopuseDocumentDate { get; set; }
        public string? UpdatePopactualsOnInvoice { get; set; }
        public string? UpdateSopactualsOnInvoice { get; set; }
        public string? ShowQuotesOnJob { get; set; }
        public string? DisplayRetentionsAsActual { get; set; }
        public string EnquiryLabourDisplayMode { get; set; } = null!;
        public string? DisplayApplicationsAsActual { get; set; }
        public string DisplayRevaluations { get; set; } = null!;
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? JobType1 { get; set; }
        public string? JobType2 { get; set; }
    }
}
