using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsexpensesConfiguration
    {
        public long TsexpensesConfigurationId { get; set; }
        public bool? AllowExpenseEntry { get; set; }
        public long NextExpenseClaimNumber { get; set; }
        public bool RequireExpenseAuthorisation { get; set; }
        public bool UseExpenseCategories { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
