using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWopproductGroupSetting
    {
        public long SiconWopproductGroupSettingId { get; set; }
        public long ProductGroupId { get; set; }
        public bool? PurchasingQuantityWhenIssuing { get; set; }
        public bool? PurchasingQuantityWhenCosting { get; set; }
        public bool? Sheets { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
