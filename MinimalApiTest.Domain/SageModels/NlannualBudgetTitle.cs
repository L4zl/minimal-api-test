using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlannualBudgetTitle
    {
        public long NlannualBudgetTitleId { get; set; }
        public int YearRelativeToCurrentYear { get; set; }
        public string BudgetTitle { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
