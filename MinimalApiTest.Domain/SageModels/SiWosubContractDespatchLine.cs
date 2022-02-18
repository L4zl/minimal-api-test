using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWosubContractDespatchLine
    {
        public long SiWosubContractDespatchLineId { get; set; }
        public long? SiWosubContractDespatchId { get; set; }
        public long? SiWosubContractLineTranId { get; set; }
        public long? BinItemId { get; set; }
        public long? TraceableBinItemId { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal? QuantityDespatched { get; set; }
        public long? SiWorksOrderLineId { get; set; }

        public virtual BinItem? BinItem { get; set; }
        public virtual SiWosubContractDespatch? SiWosubContractDespatch { get; set; }
        public virtual TraceableBinItem? TraceableBinItem { get; set; }
    }
}
