using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetHistoryView
    {
        public long SiconHmassetHistoryId { get; set; }
        public long SiconHmhistoryId { get; set; }
        public long FixedAssetId { get; set; }
        public long HistoryTransactionTypeId { get; set; }
        public long? SiconHmorderLineAssetsLineId { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public string? Details { get; set; }
        public string HireOrderNumber { get; set; } = null!;
        public string CustomerRef { get; set; } = null!;
        public string DeliveryPostalName { get; set; } = null!;
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
        public string SiconHmdocumentStatusName { get; set; } = null!;
        public long? SiconHmorderLineId { get; set; }
        public DateTime? RequestedFromDate { get; set; }
        public DateTime? OrderLineDeliveryDate { get; set; }
        public DateTime? RequestedToDate { get; set; }
        public DateTime? OrderLineCollectionDate { get; set; }
        public decimal AssetQuantity { get; set; }
        public DateTime? AssetDespatchedDate { get; set; }
        public DateTime? AssetOffHireDate { get; set; }
        public DateTime? AssetReceivedDate { get; set; }
    }
}
