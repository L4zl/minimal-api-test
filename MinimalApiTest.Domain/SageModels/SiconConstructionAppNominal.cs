using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppNominal
    {
        public long SiconConstructionAppNominalId { get; set; }
        public long? SiconConstructionApplicationId { get; set; }
        public long? SiconConstructionAppLineId { get; set; }
        public long? SijcjobId { get; set; }
        public long? SijcchdId { get; set; }
        public long? NlnominalCodeId { get; set; }
        public string? NominalRef { get; set; }
        public string? NominalCc { get; set; }
        public string? NominalDept { get; set; }
        public string? NominalName { get; set; }
        public string? Narrative { get; set; }
        public decimal? NetValue { get; set; }
        public string? AnalysisCode { get; set; }
        public string? LineType { get; set; }
        public long? TaxCodeId { get; set; }
        public string? TaxCodeString { get; set; }
        public decimal? TaxValue { get; set; }
        public long? SiconSalesOrderLineId { get; set; }
        public long? SiconPurchaseOrderLineId { get; set; }
        public string? PostingType { get; set; }
        public long? SiconRetentionId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? LinkedAppNominalId { get; set; }
        public long? SiJcTrnId { get; set; }
    }
}
