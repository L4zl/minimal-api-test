using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderLinesView
    {
        public string? HireOrderNumber { get; set; }
        public long SiconHmorderId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public long SiconHmorderLinesViewId { get; set; }
        public int SequenceNo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? RequestedFromDate { get; set; }
        public DateTime? RequestedToDate { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string CustomerAccountName { get; set; } = null!;
        public string LineType { get; set; } = null!;
        public int LineTypeId { get; set; }
        public string? FirstDescription { get; set; }
        public string? SecondDescription { get; set; }
        public bool UndefinedHirePeriod { get; set; }
        public decimal Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Duration { get; set; }
        public string? SellingUnit { get; set; }
        public decimal? LineTotal { get; set; }
        public decimal? TaxValue { get; set; }
        public decimal? TaxRate { get; set; }
        public short? Code { get; set; }
        public long? SystaxRateId { get; set; }
        public long? SiconHmdocumentStatusId { get; set; }
        public string? OrderStatus { get; set; }
        public int? ExcludeWeekends { get; set; }
        public decimal QuantityAllocated { get; set; }
        public decimal QuantityDespatched { get; set; }
        public decimal QuantityOffHire { get; set; }
        public decimal QuantityReceived { get; set; }
    }
}
