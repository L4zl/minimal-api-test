using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractProductGroup
    {
        public long SiconContractProductGroupId { get; set; }
        public long ProductGroupId { get; set; }
        public long? NlrevenueNominalCodeId { get; set; }
        public long? NldeferredRevenueNominalCodeId { get; set; }
        public long? NlbsdeferredCostNominalCodeId { get; set; }
        public long? NlplcostNominalCodeId { get; set; }
        public bool? NewContractForEachSo { get; set; }
        public bool? NewContractLineForEachSo { get; set; }
        public string? DefaultLineDescription { get; set; }
        public string? DefaultInternalDescription { get; set; }
    }
}
