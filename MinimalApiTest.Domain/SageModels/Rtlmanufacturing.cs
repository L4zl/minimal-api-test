using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Rtlmanufacturing
    {
        public long RtlmanufacturingId { get; set; }
        public long HierNodeId { get; set; }
        public int AggregateDays { get; set; }
        public decimal WorksOrderBatchMinQty { get; set; }
        public decimal WorksOrderBatchMaxQty { get; set; }
        public long? ContactId { get; set; }
        public bool CanCancelWorksOrders { get; set; }
        public bool CanCancelPurchaseOrders { get; set; }
        public long MrpreplenishmentRulesTypeId { get; set; }
        public decimal MrpreplenishmentMultipleValue { get; set; }
        public bool CanAmendPoreceiptAllocation { get; set; }
        public bool? UseDemandWarehouse { get; set; }
        public bool? UseWocompletionWarehouse { get; set; }
        public short ReplenishmentHorizonDays { get; set; }
        public bool? ApplyReorderLevelAfterMaximum { get; set; }
        public bool? BuiltBoughtDefaultMake { get; set; }
        public bool Linked { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
