using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcsimpleTransactionVw
    {
        public long PcimmediateParentId { get; set; }
        public long PcprojectItemId { get; set; }
        public long EntryTypeId { get; set; }
        public long PcprojectEntryDescriptorId { get; set; }
        public decimal GoodsAmountInBaseCurrency { get; set; }
    }
}
