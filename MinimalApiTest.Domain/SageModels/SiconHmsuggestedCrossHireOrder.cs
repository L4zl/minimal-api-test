using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmsuggestedCrossHireOrder
    {
        public long SuggestedCrossHireOrderId { get; set; }
        public long SiconHmorderLineAssetsLineId { get; set; }
        public long SubCategoryId { get; set; }
        public DateTime? DateRequired { get; set; }
        public int? LeadTimeInDays { get; set; }
        public DateTime? NeedToOrderBy { get; set; }
        public decimal? QuantityRequired { get; set; }
        public bool? IsSelected { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public decimal? UnitPrice { get; set; }
        public string? Description { get; set; }
        public long? TaxCodeId { get; set; }
        public long? WarehouseId { get; set; }
    }
}
