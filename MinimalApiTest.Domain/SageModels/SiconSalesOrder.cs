using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrder
    {
        public long SiconSalesOrderId { get; set; }
        public long? CustomerId { get; set; }
        public long? SiJcJobId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public long? DocumentStatusId { get; set; }
        public string? DocumentNo { get; set; }
        public long? SiJcChdId { get; set; }
        public string? DeliveryPostalName { get; set; }
        public string? DeliveryAddressLine1 { get; set; }
        public string? DeliveryAddressLine2 { get; set; }
        public string? DeliveryAddressLine3 { get; set; }
        public string? DeliveryAddressLine4 { get; set; }
        public string? DeliveryCity { get; set; }
        public string? DeliveryPostCode { get; set; }
        public string? Contact { get; set; }
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public DateTime? PromisedDate { get; set; }
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
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        public long? SiJcphaseId { get; set; }
        public long? SiJcStageId { get; set; }
        public long? SiJcActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
        public bool? IsQuote { get; set; }
        public string? County { get; set; }
        public string? Country { get; set; }
        public string? QuoteStatus { get; set; }
        public decimal? QuoteProbability { get; set; }
        public DateTime? EstimatedOrderDate { get; set; }
        public bool? IsTemplate { get; set; }
        public long? DefaultTaxCodeId { get; set; }
    }
}
