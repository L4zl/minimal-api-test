using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountReportCategoryType
    {
        public NlaccountReportCategoryType()
        {
            NlaccountReportCategories = new HashSet<NlaccountReportCategory>();
        }

        public long NlaccountReportCategoryTypeId { get; set; }
        public long NlaccountReportTypeId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<NlaccountReportCategory> NlaccountReportCategories { get; set; }
    }
}
