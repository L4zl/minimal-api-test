using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmstockAvailableForCase
    {
        public long SiSmstockAvailableForCaseId { get; set; }
        public long? ItemId { get; set; }
        public decimal? Quantity { get; set; }
        public long? SiJcEmpId { get; set; }
        public long? SiSmcaseId { get; set; }
        public long? AllocationId { get; set; }
        public long? SiSmcaseStockTransferId { get; set; }
        public long? BinItemId { get; set; }
        public long? SiSmdeliveryCodeId { get; set; }
        public long? ActionId { get; set; }
        public long? SiconStockTransferItemId { get; set; }
        public long? SiJcTrnId { get; set; }
        public long? RevenueSiJcTrnId { get; set; }
        public int? BillingPlan { get; set; }
        public string? BillingNote { get; set; }
        public bool? ConfirmedReceived { get; set; }
        public bool? Despatched { get; set; }
        public bool? PickingListPrinted { get; set; }
        public long? ToWarehouseId { get; set; }
        public bool? DeliverToCustomer { get; set; }
        public long? PoporderReturnLineId { get; set; }
    }
}
