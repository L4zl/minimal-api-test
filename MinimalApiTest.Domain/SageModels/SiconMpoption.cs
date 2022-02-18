using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconMpoption
    {
        public long SiconMpoptionId { get; set; }
        public bool? ExcludePurchaseOrders { get; set; }
        public bool? ExcludeSalesOrders { get; set; }
        public bool? IncludeSalesProformas { get; set; }
        public bool? IncludeSalesQuotes { get; set; }
        public bool? IncludeSalesOrdersOnHold { get; set; }
        public string? GroupPoandWowithin { get; set; }
        public bool? IncludeExistingWorksOrders { get; set; }
        public bool? WoallowOverOrdering { get; set; }
        public bool? GenerateSuggestedWorksOrders { get; set; }
        public bool? CreateWoforItemsSetToMake { get; set; }
        public bool? GenerateForStockBelowMin { get; set; }
        public bool? SeperateForMinStockAndSo { get; set; }
        public bool? PoallowOverOrdering { get; set; }
        public bool? UsePastDatesOnPo { get; set; }
        public bool? IgnoreStockOnPo { get; set; }
        public bool? UseMinStockOnPo { get; set; }
        public bool? UseReOrderStockOnPo { get; set; }
        public long? UserNumber { get; set; }
        public bool? SeperateWarehouses { get; set; }
    }
}
