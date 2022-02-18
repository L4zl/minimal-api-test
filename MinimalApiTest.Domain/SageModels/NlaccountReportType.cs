using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlaccountReportType
    {
        public NlaccountReportType()
        {
            NlaccountReportCategories = new HashSet<NlaccountReportCategory>();
            NldefaultNominalAccounts = new HashSet<NldefaultNominalAccount>();
            NlfinancialReportCategories = new HashSet<NlfinancialReportCategory>();
            NlfinancialReportLayouts = new HashSet<NlfinancialReportLayout>();
            NlstatementLayouts = new HashSet<NlstatementLayout>();
        }

        public long NlaccountReportTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlaccountReportCategory> NlaccountReportCategories { get; set; }
        public virtual ICollection<NldefaultNominalAccount> NldefaultNominalAccounts { get; set; }
        public virtual ICollection<NlfinancialReportCategory> NlfinancialReportCategories { get; set; }
        public virtual ICollection<NlfinancialReportLayout> NlfinancialReportLayouts { get; set; }
        public virtual ICollection<NlstatementLayout> NlstatementLayouts { get; set; }
    }
}
