using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetHistory
    {
        public long SiconHmassetHistoryId { get; set; }
        public long SiconHmhistoryId { get; set; }
        public long FixedAssetId { get; set; }
        public long HistoryTransactionTypeId { get; set; }
        public long? SiconHminspectionHistoryId { get; set; }
        public long? SiconHmorderLineAssetsLineId { get; set; }
        public string? WarehouseName { get; set; }
        public string? BinName { get; set; }
        public string? TransferredToWarehouseName { get; set; }
        public string? TransferredToBinName { get; set; }
        public long? TransactionHistoryId { get; set; }
        public string? StockItemCode { get; set; }
        public string? InternalAreaName { get; set; }
        public string? Reference { get; set; }
        public string? SecondReference { get; set; }
        public string? AssetTypeName { get; set; }
        public string? AssetStatusName { get; set; }
        public string? AssetLocationName { get; set; }
        public long? SiconContractId { get; set; }
        public long? SiconContractLineId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
