using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPurchaseOrder
    {
        public long SiconPurchaseOrderId { get; set; }
        public long SupplierId { get; set; }
        public long? SiJcJobId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public long? DocumentStatusId { get; set; }
        public string? DocumentNo { get; set; }
        public long? SiJcChdId { get; set; }
        public string? PostalName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? City { get; set; }
        public string? PostCode { get; set; }
        public string? Contact { get; set; }
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? AnalysisCode6 { get; set; }
        public string? AnalysisCode7 { get; set; }
        public string? AnalysisCode8 { get; set; }
        public string? AnalysisCode9 { get; set; }
        public string? AnalysisCode10 { get; set; }
        public string? AnalysisCode11 { get; set; }
        public string? AnalysisCode12 { get; set; }
        public string? AnalysisCode13 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        public long? SuppDeliveryAddressId { get; set; }
        public long? SiJcphaseId { get; set; }
        public long? SiJcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public long? SiconJobAddressId { get; set; }
        public string? OrderOriginator { get; set; }
    }
}
