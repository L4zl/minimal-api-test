using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectItemBudgetHistory
    {
        public PcprojectItemBudgetHistory()
        {
            PcprojectItemBudgetPdHistories = new HashSet<PcprojectItemBudgetPdHistory>();
        }

        public long PcprojectItemBudgetHistoryId { get; set; }
        public long PcprojectItemId { get; set; }
        public DateTime DateOfChange { get; set; }
        public string UserName { get; set; } = null!;
        public decimal TotalCostQuantity { get; set; }
        public decimal TotalCostValue { get; set; }
        public decimal TotalRevenueQuantity { get; set; }
        public decimal TotalRevenueValue { get; set; }
        public string? Project { get; set; }
        public string? CostItemOrGroup { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
        public virtual ICollection<PcprojectItemBudgetPdHistory> PcprojectItemBudgetPdHistories { get; set; }
    }
}
