using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NominalUsage
    {
        public NominalUsage()
        {
            ProdGroupNominalCodes = new HashSet<ProdGroupNominalCode>();
            StockItemNominalCodes = new HashSet<StockItemNominalCode>();
        }

        public long NominalUsageId { get; set; }
        public string NominalUsageName { get; set; } = null!;

        public virtual ICollection<ProdGroupNominalCode> ProdGroupNominalCodes { get; set; }
        public virtual ICollection<StockItemNominalCode> StockItemNominalCodes { get; set; }
    }
}
