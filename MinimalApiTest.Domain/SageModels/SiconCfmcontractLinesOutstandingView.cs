using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmcontractLinesOutstandingView
    {
        public string? ContractNumber { get; set; }
        public long SiconContractId { get; set; }
        public long SiconContractLineId { get; set; }
        public short? FrequencyValue { get; set; }
        public decimal? Value { get; set; }
        public DateTime? NextDueDate { get; set; }
        public long? ItemId { get; set; }
        public string? Description { get; set; }
        public long SlcustomerAccountId { get; set; }
    }
}
