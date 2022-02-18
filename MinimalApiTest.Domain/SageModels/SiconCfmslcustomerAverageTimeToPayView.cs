using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmslcustomerAverageTimeToPayView
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long SlcustomerAccountId { get; set; }
        public long SyspaymentTermsBasisId { get; set; }
        public short PaymentTermsInDays { get; set; }
        public int AverageTimeToPay { get; set; }
        public DateTime? AvgTimeToPayDateLastUpdated { get; set; }
        public int Days { get; set; }
    }
}
