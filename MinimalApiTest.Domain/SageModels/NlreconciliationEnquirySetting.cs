using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlreconciliationEnquirySetting
    {
        public long NlreconciliationEnquirySettingId { get; set; }
        public long NlreconciliationEnquiryTypeId { get; set; }
        public long NlnominalAccountId { get; set; }

        public virtual NlnominalAccount NlnominalAccount { get; set; } = null!;
        public virtual NlreconciliationEnquiryType NlreconciliationEnquiryType { get; set; } = null!;
    }
}
