using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NewSiconStockMovementsView
    {
        public long? SortId { get; set; }
        public long? Id { get; set; }
        public long? WarehouseId { get; set; }
        public long? ItemId { get; set; }
        public string? Code { get; set; }
        public string Type { get; set; } = null!;
        public string? DocumentStatus { get; set; }
        public string? Wonumber { get; set; }
        public DateTime? DateRequired { get; set; }
        public DateTime? DateRequiredRequestedFirst { get; set; }
        public decimal? FreeStock { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Allocated { get; set; }
        public decimal? Issued { get; set; }
        public string? DocumentNo { get; set; }
        public decimal? PercentStockCover { get; set; }
        public long? LineId { get; set; }
        public string InOrOut { get; set; } = null!;
        public decimal? Price { get; set; }
        public string? DocumentType { get; set; }
        public string? LineComment { get; set; }
        public long SiWorksOrderLineId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? Bomlevel { get; set; }
        public long? ParentWoid { get; set; }
        public int Priority { get; set; }
        public long? RowNumber { get; set; }
        public long? FulfilmentMethod { get; set; }
        public DateTime? RescheduleDate { get; set; }
    }
}
