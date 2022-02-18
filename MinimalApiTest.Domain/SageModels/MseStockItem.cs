using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseStockItem
    {
        public MseStockItem()
        {
            BomBuildProducts = new HashSet<BomBuildProduct>();
        }

        public long MseStockItemId { get; set; }
        public string StockCode { get; set; } = null!;
        public int AggregateDays { get; set; }
        public decimal WorksOrderBatchMinQty { get; set; }
        public decimal WorksOrderBatchMaxQty { get; set; }
        public long? MseContactId { get; set; }
        public bool CanCancelWorksOrders { get; set; }
        public bool CanCancelPurchaseOrders { get; set; }
        public long MrpreplenishmentRulesTypeId { get; set; }
        public decimal MrpreplenishmentMultipleValue { get; set; }
        public bool CanAmendPoreceiptAllocation { get; set; }
        public bool Linked { get; set; }
        public bool UseDemandWarehouse { get; set; }
        public bool UseWocompletionWarehouse { get; set; }
        public bool ApplyReorderLevelAfterMaximum { get; set; }
        public short ReplenishmentHorizonDays { get; set; }
        public bool BuiltBoughtDefaultMake { get; set; }
        public string AdditionalDescription2 { get; set; } = null!;
        public short LeadTime { get; set; }
        public decimal StdCost { get; set; }
        public bool Conversion { get; set; }
        public decimal BoughtInUnit { get; set; }
        public string BoughtInDesc { get; set; } = null!;
        public decimal ProcessUnit { get; set; }
        public string ProcessDesc { get; set; } = null!;
        public bool AutoUpdateSuppliers { get; set; }
        public bool Quarantine { get; set; }
        public decimal? MaximumStockLevel { get; set; }
        public int ShelfLifeNo { get; set; }
        public long? ShelfLifeInterval { get; set; }
        public decimal MaximumBatchSize { get; set; }
        public string BuyerCode { get; set; } = null!;
        public bool MakeItem { get; set; }
        public decimal OrderingMethod { get; set; }
        public decimal OrderMultiple { get; set; }
        public decimal ScrapPercent { get; set; }
        public bool StockConversionRound { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public bool BulkIssue { get; set; }
        public short BomItemType { get; set; }
        public string AdditionalDescription1 { get; set; } = null!;
        public bool CostFreeze { get; set; }
        public long MsmCostHeadingId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MseContact? MseContact { get; set; }
        public virtual MsmCostHeading MsmCostHeading { get; set; } = null!;
        public virtual ICollection<BomBuildProduct> BomBuildProducts { get; set; }
    }
}
