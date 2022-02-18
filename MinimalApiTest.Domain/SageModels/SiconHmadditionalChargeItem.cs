using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmadditionalChargeItem
    {
        public long SiconHmadditionalChargeItemId { get; set; }
        public string? Name { get; set; }
        public bool? UseStockItem { get; set; }
        public long? ItemId { get; set; }
        public long? SopadditionalChargeId { get; set; }
        public bool? AskQuantityOnAssetsReceived { get; set; }
        public bool? UseFreeTextLine { get; set; }
        public string? DefaultDescription { get; set; }
        public long? FreeTextNominalAccountId { get; set; }
        public bool? IsManualUserSelect { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
