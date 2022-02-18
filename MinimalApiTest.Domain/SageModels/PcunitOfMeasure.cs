using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcunitOfMeasure
    {
        public PcunitOfMeasure()
        {
            BlbillLines = new HashSet<BlbillLine>();
            Blcontracts = new HashSet<Blcontract>();
            Pcaccruals = new HashSet<Pcaccrual>();
            PccostItemTypes = new HashSet<PccostItemType>();
            PccostItems = new HashSet<PccostItem>();
            PcprojectEntries = new HashSet<PcprojectEntry>();
            PcprojectItems = new HashSet<PcprojectItem>();
        }

        public long PcunitOfMeasureId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
        public virtual ICollection<Blcontract> Blcontracts { get; set; }
        public virtual ICollection<Pcaccrual> Pcaccruals { get; set; }
        public virtual ICollection<PccostItemType> PccostItemTypes { get; set; }
        public virtual ICollection<PccostItem> PccostItems { get; set; }
        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
    }
}
