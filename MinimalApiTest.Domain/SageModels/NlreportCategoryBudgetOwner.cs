using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlreportCategoryBudgetOwner
    {
        public long NlreportCategoryBudgetOwnerId { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public long NlreportCategoryBudgetId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlreportCategoryBudget NlreportCategoryBudget { get; set; } = null!;
    }
}
