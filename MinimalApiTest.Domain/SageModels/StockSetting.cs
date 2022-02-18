using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StockSetting
    {
        public long StockSettingId { get; set; }
        public bool UseMultipleLocations { get; set; }
        public bool UseSearchCategories { get; set; }
        public bool IntegrateWithNominal { get; set; }
        public bool? ProfitPercentOfRevenue { get; set; }
        public bool UpdateLabelFile { get; set; }
        public bool AllocateIndividualItems { get; set; }
        public bool RecordNosOnGoodsReceived { get; set; }
        public DateTime? AllItemsLastArchivedUpTo { get; set; }
        public string? LastArchiveRunBy { get; set; }
        public DateTime? LastArchiveRunOn { get; set; }
        public string? LastPurgeArchiveRunBy { get; set; }
        public DateTime? LastPurgeArchiveRunOn { get; set; }
        public DateTime? ArchiveLastPurgedUpTo { get; set; }
        public string? LastProveBalancesRunBy { get; set; }
        public DateTime? LastProveBalancesRunOn { get; set; }
        public bool? AllowFulfilmentFromStock { get; set; }
        public bool OkfulfilmntFromSuppViaWarhouse { get; set; }
        public bool OkfulfilmntDirectToCustomer { get; set; }
        public bool UseCurrentStockForFulfilment { get; set; }
        public bool PostCosforSop { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool AllowNegStockTake { get; set; }
        public bool AllowNegStockTakeWithPo { get; set; }
        public string LastTraceArchiveRunBy { get; set; } = null!;
        public DateTime? LastTraceArchiveRunOn { get; set; }
        public string LastTracePurgeArchiveRunBy { get; set; } = null!;
        public DateTime? LastTracePurgeArchiveRunOn { get; set; }
        public DateTime? AllTraceItemsLastArchivedUpTo { get; set; }
        public DateTime? TraceArchiveLastPurgedUpTo { get; set; }
        public bool UseLandedCosts { get; set; }
        public long? LandedCostsNominalCode { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlnominalAccount? LandedCostsNominalCodeNavigation { get; set; }
    }
}
