using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSuggestedPoline
    {
        public long SiSuggestedPolineId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public long? SupplierId { get; set; }
        public string? SupplerReference { get; set; }
        public string? SupplierName { get; set; }
        public decimal? UnitPrice { get; set; }
        public long? WarehouseId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public decimal? LeadTime { get; set; }
        public string? Description { get; set; }
        public bool? IsDirectDelivery { get; set; }
        public long? SoporderFulfilmentMethodId { get; set; }
        public long? ReasonLineId { get; set; }
        public long? StockItemUnitId { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public bool? SpareBit1 { get; set; }
        public bool? SpareBit2 { get; set; }
        public bool? SpareBit3 { get; set; }
        public decimal? QtyInStock { get; set; }
        public decimal? QtyOnOrder { get; set; }
        public string? SupplierPartNumber { get; set; }
        public string? Reason { get; set; }
        public DateTime? RaiseDate { get; set; }
        public string? UnitPriceReason { get; set; }
        public long? UomrefId { get; set; }
        public decimal? Uomquantity { get; set; }
        public string? Currency { get; set; }
        public string? ReasonType { get; set; }
    }
}
