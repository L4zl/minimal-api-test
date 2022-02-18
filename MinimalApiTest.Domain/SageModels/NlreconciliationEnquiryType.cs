using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlreconciliationEnquiryType
    {
        public NlreconciliationEnquiryType()
        {
            NlreconciliationEnquirySettings = new HashSet<NlreconciliationEnquirySetting>();
        }

        public long NlreconciliationEnquiryTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<NlreconciliationEnquirySetting> NlreconciliationEnquirySettings { get; set; }
    }
}
