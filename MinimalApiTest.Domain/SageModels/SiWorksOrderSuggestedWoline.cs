using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderSuggestedWoline
    {
        public long SiWorksOrderSuggestedWolineId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public long? WarehouseId { get; set; }
        public string? Reason { get; set; }
        public string? Number { get; set; }
        public decimal? FreeStock { get; set; }
        public string? Uom { get; set; }
        public DateTime? StartDate { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public bool? IsSubAssembly { get; set; }
        public bool? SpareBit1 { get; set; }
        public bool? SpareBit2 { get; set; }
        public bool? SpareBit3 { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public bool? MinStockLevel { get; set; }
        public long? UomrefId { get; set; }
        public decimal? Uomquantity { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
