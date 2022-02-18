using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlreportCategoryBudget
    {
        public NlreportCategoryBudget()
        {
            NlnominalAccounts = new HashSet<NlnominalAccount>();
            NlreportCategoryBudgetOwners = new HashSet<NlreportCategoryBudgetOwner>();
            NlreportCategoryBudgetYearValues = new HashSet<NlreportCategoryBudgetYearValue>();
            PoprequisitionLines = new HashSet<PoprequisitionLine>();
        }

        public long NlreportCategoryBudgetId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public long SysaccountStatusId { get; set; }
        public string StatusChangedBy { get; set; } = null!;
        public DateTime? StatusChangedDateTime { get; set; }

        public virtual SysaccountStatus SysaccountStatus { get; set; } = null!;
        public virtual ICollection<NlnominalAccount> NlnominalAccounts { get; set; }
        public virtual ICollection<NlreportCategoryBudgetOwner> NlreportCategoryBudgetOwners { get; set; }
        public virtual ICollection<NlreportCategoryBudgetYearValue> NlreportCategoryBudgetYearValues { get; set; }
        public virtual ICollection<PoprequisitionLine> PoprequisitionLines { get; set; }
    }
}
