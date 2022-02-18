using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderListView
    {
        public long? RowNumber { get; set; }
        public string? Wonumber { get; set; }
        public string? Woname { get; set; }
        public decimal? Quantity { get; set; }
        public string Warehouse { get; set; } = null!;
        public string? GeneratedDate { get; set; }
        public string? StartDate { get; set; }
        public string? DueDate { get; set; }
        public string? Area { get; set; }
        public string SalesOrder { get; set; } = null!;
        public string? Status { get; set; }
        public long SiWorksOrderId { get; set; }
        public long? Bomid { get; set; }
        public string? Wobomversion { get; set; }
        public string? LatestBomversion { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
    }
}
