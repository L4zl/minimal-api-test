using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmdelAndCollView
    {
        public long SiconHmorderId { get; set; }
        public string? HireOrderNumber { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public string? CustomerAccountName { get; set; }
        public string? CategoryDescription { get; set; }
        public string? SubCategoryDescription { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string CustomerRef { get; set; } = null!;
        public int LineSequenceNo { get; set; }
        public DateTime? RequestedFromDate { get; set; }
        public DateTime? RequestedToDate { get; set; }
        public bool UndefinedHirePeriod { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? CollectionDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal? OutstandingQuantityToDespatch { get; set; }
        public decimal? OutstandingQuantityToReceive { get; set; }
        public decimal QuantityOffHire { get; set; }
        public long? SiconHmdocumentStatusId { get; set; }
        public string? OrderStatus { get; set; }
        public string? CustomStatus { get; set; }
        public string? DeliveryPostalName { get; set; }
        public string? DeliveryAddressLine1 { get; set; }
        public string? DeliveryAddressLine2 { get; set; }
        public string? DeliveryAddressLine3 { get; set; }
        public string? DeliveryAddressLine4 { get; set; }
        public string? DeliveryCity { get; set; }
        public string? DeliveryPostCode { get; set; }
        public string IsQuoteConvertedToOrder { get; set; } = null!;
        public long? ConvertedToOrderId { get; set; }
        public string OrderTypeName { get; set; } = null!;
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public string AnalysisCode7 { get; set; } = null!;
        public string AnalysisCode8 { get; set; } = null!;
        public string AnalysisCode9 { get; set; } = null!;
        public string AnalysisCode10 { get; set; } = null!;
        public string AnalysisCode11 { get; set; } = null!;
        public string AnalysisCode12 { get; set; } = null!;
        public string AnalysisCode13 { get; set; } = null!;
        public string AnalysisCode14 { get; set; } = null!;
        public string AnalysisCode15 { get; set; } = null!;
        public string AnalysisCode16 { get; set; } = null!;
        public string AnalysisCode17 { get; set; } = null!;
        public string AnalysisCode18 { get; set; } = null!;
        public string AnalysisCode19 { get; set; } = null!;
        public string AnalysisCode20 { get; set; } = null!;
    }
}
