using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BommakeupStockOption
    {
        public BommakeupStockOption()
        {
            Bombuilds = new HashSet<Bombuild>();
            Old200Bomallocations = new HashSet<Old200Bomallocation>();
        }

        public long BommakeupStockOptionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Bombuild> Bombuilds { get; set; }
        public virtual ICollection<Old200Bomallocation> Old200Bomallocations { get; set; }
    }
}
