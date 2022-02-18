using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomallocFinishedItem
    {
        public BomallocFinishedItem()
        {
            BomallocComponents = new HashSet<BomallocComponent>();
            InverseIsComponentOf = new HashSet<BomallocFinishedItem>();
        }

        public long BomallocFinishedItemId { get; set; }
        public long? BomallocationId { get; set; }
        public long StockItemId { get; set; }
        public decimal QuantityForMake { get; set; }
        public long? Bomid { get; set; }
        public string Bomversion { get; set; } = null!;
        public bool IsIntermediateItem { get; set; }
        public decimal QuantityBuild { get; set; }
        public decimal QuantityUnallocated { get; set; }
        public long? IsComponentOfId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Bom? Bom { get; set; }
        public virtual Old200Bomallocation? Bomallocation { get; set; }
        public virtual BomallocFinishedItem? IsComponentOf { get; set; }
        public virtual ICollection<BomallocComponent> BomallocComponents { get; set; }
        public virtual ICollection<BomallocFinishedItem> InverseIsComponentOf { get; set; }
    }
}
