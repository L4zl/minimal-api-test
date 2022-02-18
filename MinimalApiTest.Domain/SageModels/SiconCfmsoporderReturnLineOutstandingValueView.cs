using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmsoporderReturnLineOutstandingValueView
    {
        public long SoporderReturnId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long? SyscurrencyId { get; set; }
        public decimal? Value { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? ValueAccount { get; set; }
        public decimal? NetValueAccount { get; set; }
    }
}
