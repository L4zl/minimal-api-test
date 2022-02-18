using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiNlnominalDetail
    {
        public long SiNlnominalDetailId { get; set; }
        public long NlnominalAccountId { get; set; }
        public bool ReconcileMustBalance { get; set; }
    }
}
