using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Pcaccrual
    {
        public long PcaccrualId { get; set; }
        public string Narrative { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public long PcprojectItemId { get; set; }
        public DateTime? ReversalDate { get; set; }
        public decimal TotalCost { get; set; }
        public decimal ValueToBill { get; set; }
        public decimal Quantity { get; set; }
        public decimal ChargeRate { get; set; }
        public decimal UnitCost { get; set; }
        public string BsnominalAcref { get; set; } = null!;
        public string BsnominalCc { get; set; } = null!;
        public string BsnominalDept { get; set; } = null!;
        public string PlnominalAcref { get; set; } = null!;
        public string PlnominalCc { get; set; } = null!;
        public string PlnominalDept { get; set; } = null!;
        public string TransactionAnalysisCode { get; set; } = null!;
        public long PcunitOfMeasureId { get; set; }
        public decimal? MarkupPercentage { get; set; }
        public bool IsComplete { get; set; }
        public decimal GoodsValue { get; set; }
        public decimal OverheadValue { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime AccrualDate { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
        public virtual PcunitOfMeasure PcunitOfMeasure { get; set; } = null!;
    }
}
