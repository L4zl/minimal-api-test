using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectBillingSopview
    {
        public long SoporderReturnLineId { get; set; }
        public decimal LineQuantity { get; set; }
        public decimal UnitSellingPrice { get; set; }
        public decimal LineTotalValue { get; set; }
        public long? SiJcTrnsoplinkId { get; set; }
        public long? Sijctrnid { get; set; }
        public string? TransType { get; set; }
        public string? StockItemText { get; set; }
        public string? Employee { get; set; }
        public string? RateDescription { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SiJcChdId { get; set; }
        public string? CostCode { get; set; }
        public decimal? CostQty { get; set; }
        public decimal? CostUnit { get; set; }
        public decimal? SellingUnit { get; set; }
        public decimal? CostTotal { get; set; }
        public decimal? SellingTotal { get; set; }
    }
}
