using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierFactorHouse
    {
        public long PlsupplierFactorHouseId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long PlfactorHouseId { get; set; }
        public bool FactorHouseInUse { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlfactorHouse PlfactorHouse { get; set; } = null!;
        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
    }
}
