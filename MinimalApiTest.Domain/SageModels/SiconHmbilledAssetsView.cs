using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmbilledAssetsView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string? HireOrderNumber { get; set; }
        public string? CustomerRef { get; set; }
        public int SequenceNo { get; set; }
        public string SiconHmbillLineWarningMessage { get; set; } = null!;
        public DateTime? RequestedFromDate { get; set; }
        public string? DeliveryAddressDescription { get; set; }
        public string? CategoryDescription { get; set; }
        public string? SubCategoryDescription { get; set; }
        public decimal? Quantity { get; set; }
        public string? AssetCode { get; set; }
        public string? SerialNumber { get; set; }
        public DateTime? DespatchedDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? BilledFromDate { get; set; }
        public DateTime? BilledToDate { get; set; }
        public int? BilledNumberOfDays { get; set; }
        public decimal? DailyHireCharge { get; set; }
        public decimal? BilledTotalHireCharge { get; set; }
        public string SopdocumentNo { get; set; } = null!;
        public DateTime? SopdocumentDate { get; set; }
        public decimal SoptotalNetValue { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
    }
}
