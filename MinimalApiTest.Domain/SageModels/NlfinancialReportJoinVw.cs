using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlfinancialReportJoinVw
    {
        public long NlfinancialReportRowId { get; set; }
        public long? NlfinancialReportCategoryId { get; set; }
        public long? NlaccountReportCategoryId { get; set; }
    }
}
