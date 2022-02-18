using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomcostsBooked
    {
        public long BomcostsBookedId { get; set; }
        public long BombuildId { get; set; }
        public long? NominalCodeId { get; set; }
        public string NominalAccount { get; set; } = null!;
        public string CostCentre { get; set; } = null!;
        public string Department { get; set; } = null!;
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Bombuild Bombuild { get; set; } = null!;
    }
}
