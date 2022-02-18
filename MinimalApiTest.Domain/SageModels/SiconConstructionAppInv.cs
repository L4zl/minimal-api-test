using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppInv
    {
        public long SiconConstructionAppInvId { get; set; }
        public long? SiconConstructionApplicationId { get; set; }
        public long? SiconConstructionAppLineId { get; set; }
        public string Reference { get; set; } = null!;
        public DateTime? PrintedDate { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public string Ledger { get; set; } = null!;
        public string DocumentType { get; set; } = null!;
        public decimal? CumulativeOriginal { get; set; }
        public decimal? CumulativeRetention { get; set; }
        public decimal? InvoicedOriginal { get; set; }
        public decimal? InvoicedRetention { get; set; }
        public decimal? ReceivedOriginal { get; set; }
        public decimal? ReceivedRetention { get; set; }
        public decimal? ThisOriginal { get; set; }
        public decimal? ThisRetention { get; set; }
        public decimal Vatrate { get; set; }
        public decimal ValuationOriginal { get; set; }
        public decimal ValuationRetention { get; set; }
        public DateTime InvoiceDate { get; set; }
        public long InvoiceUrn { get; set; }
        public bool InvoicePosted { get; set; }
        public decimal? CumulativeDiscount { get; set; }
        public decimal? CumulativeTax { get; set; }
        public decimal? InvoicedDiscount { get; set; }
        public decimal? InvoicedTax { get; set; }
        public decimal? ReceivedDiscount { get; set; }
        public decimal? ReceivedTax { get; set; }
        public decimal? ThisDiscount { get; set; }
        public decimal? ThisTax { get; set; }
        public decimal? ValuationDiscount { get; set; }
        public decimal? ValuationTax { get; set; }
        public decimal CumulativeValuationOriginal { get; set; }
        public decimal CumulativeValuationRetention { get; set; }
        public decimal CumulativeValuationDiscount { get; set; }
        public decimal CumulativeValuationTax { get; set; }
        public string? ApplicationReference { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? ApplicationPaymentDueDate { get; set; }
        public DateTime? ApplicationValuationDate { get; set; }
        public long? SiJctrnId { get; set; }
    }
}
