using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderFinishedItem
    {
        public long SiWorksOrderFinishedItemId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? ItemId { get; set; }
        public long? WarehouseId { get; set; }
        public long? SiWorksOrderLineId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QuantityBooked { get; set; }
        public bool? IsRecieved { get; set; }
        public bool? IsComponent { get; set; }
        public bool? Deleted { get; set; }
        public string? FinishedItemProductGrade { get; set; }
        public DateTime? FinishedItemUseByDate { get; set; }
        public DateTime? FinishedItemSellByDate { get; set; }
        public decimal? AmountOfTotalCost { get; set; }
        public string? BinName { get; set; }
        public string? TraceableNo { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public string? SpareText4 { get; set; }
        public string? SpareText5 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public decimal? SpareNumber4 { get; set; }
        public decimal? SpareNumber5 { get; set; }
        public string? SpareMemo1 { get; set; }
        public string? SpareMemo2 { get; set; }
        public decimal? ScrappedQuantity { get; set; }
        public DateTime? Updateddate { get; set; }
        public string? Updateduser { get; set; }
        public bool? ByProduct { get; set; }
        public decimal? OriginalQuantity { get; set; }
    }
}
