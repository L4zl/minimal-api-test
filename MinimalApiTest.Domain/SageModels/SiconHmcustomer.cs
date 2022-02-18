using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmcustomer
    {
        public long SiconHmcustomerId { get; set; }
        public long SlcustomerAccount { get; set; }
        public bool? IsExcludeBankHolidays { get; set; }
    }
}
