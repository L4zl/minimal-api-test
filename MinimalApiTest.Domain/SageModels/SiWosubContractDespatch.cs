using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWosubContractDespatch
    {
        public SiWosubContractDespatch()
        {
            SiWosubContractDespatchLines = new HashSet<SiWosubContractDespatchLine>();
        }

        public long SiWosubContractDespatchId { get; set; }
        public string? SiWosubContractDespatchNoteNo { get; set; }

        public virtual ICollection<SiWosubContractDespatchLine> SiWosubContractDespatchLines { get; set; }
    }
}
