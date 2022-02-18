using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountReportCategory
    {
        public NlaccountReportCategory()
        {
            NlfinancialReportCategories = new HashSet<NlfinancialReportCategory>();
            NlnominalAccountNlaccountReportCategories = new HashSet<NlnominalAccount>();
            NlnominalAccountNlaccountSofaCategories = new HashSet<NlnominalAccount>();
            NlstatementLayoutRows = new HashSet<NlstatementLayoutRow>();
        }

        public long NlaccountReportCategoryId { get; set; }
        public long NlaccountReportTypeId { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long NlaccountReportCategoryTypeId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlaccountReportCategoryType NlaccountReportCategoryType { get; set; } = null!;
        public virtual NlaccountReportType NlaccountReportType { get; set; } = null!;
        public virtual ICollection<NlfinancialReportCategory> NlfinancialReportCategories { get; set; }
        public virtual ICollection<NlnominalAccount> NlnominalAccountNlaccountReportCategories { get; set; }
        public virtual ICollection<NlnominalAccount> NlnominalAccountNlaccountSofaCategories { get; set; }
        public virtual ICollection<NlstatementLayoutRow> NlstatementLayoutRows { get; set; }
    }
}
