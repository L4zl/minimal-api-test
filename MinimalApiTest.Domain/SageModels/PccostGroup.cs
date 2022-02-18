using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PccostGroup
    {
        public PccostGroup()
        {
            PccostGroupAnalysisFields = new HashSet<PccostGroupAnalysisField>();
            PcprojectItems = new HashSet<PcprojectItem>();
        }

        public long PccostGroupId { get; set; }
        public long PcgroupingLevelId { get; set; }
        public string Code { get; set; } = null!;
        public string Title { get; set; } = null!;
        public bool AvailableForSelection { get; set; }
        public string Description { get; set; } = null!;
        public decimal BudgetCostQuantity { get; set; }
        public decimal BudgetCostValue { get; set; }
        public decimal BudgetRevenueQuantity { get; set; }
        public decimal BudgetRevenueValue { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcgroupingLevel PcgroupingLevel { get; set; } = null!;
        public virtual ICollection<PccostGroupAnalysisField> PccostGroupAnalysisFields { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
    }
}
