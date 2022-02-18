using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystraderLocationType
    {
        public SystraderLocationType()
        {
            PlfactorHouseLocations = new HashSet<PlfactorHouseLocation>();
            PlsupplierLocations = new HashSet<PlsupplierLocation>();
            SlcustomerLocations = new HashSet<SlcustomerLocation>();
        }

        public long SystraderLocationTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlfactorHouseLocation> PlfactorHouseLocations { get; set; }
        public virtual ICollection<PlsupplierLocation> PlsupplierLocations { get; set; }
        public virtual ICollection<SlcustomerLocation> SlcustomerLocations { get; set; }
    }
}
