using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlfactorHouse
    {
        public PlfactorHouse()
        {
            PlfactorHouseContacts = new HashSet<PlfactorHouseContact>();
            PlfactorHouseLocations = new HashSet<PlfactorHouseLocation>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            PlsupplierFactorHouses = new HashSet<PlsupplierFactorHouse>();
        }

        public long PlfactorHouseId { get; set; }
        public int FactorNumber { get; set; }
        public string Name { get; set; } = null!;
        public string TheirReference { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PlfactorHouseContact> PlfactorHouseContacts { get; set; }
        public virtual ICollection<PlfactorHouseLocation> PlfactorHouseLocations { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<PlsupplierFactorHouse> PlsupplierFactorHouses { get; set; }
    }
}
