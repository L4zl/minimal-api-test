using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BommakeupSubAssOption
    {
        public BommakeupSubAssOption()
        {
            Bombuilds = new HashSet<Bombuild>();
            Old200Bomallocations = new HashSet<Old200Bomallocation>();
        }

        public long BommakeupSubAssOptionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Bombuild> Bombuilds { get; set; }
        public virtual ICollection<Old200Bomallocation> Old200Bomallocations { get; set; }
    }
}
