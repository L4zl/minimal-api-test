using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomstatusType
    {
        public BomstatusType()
        {
            BomcheckedOuts = new HashSet<BomcheckedOut>();
            Boms = new HashSet<Bom>();
        }

        public long BomstatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomcheckedOut> BomcheckedOuts { get; set; }
        public virtual ICollection<Bom> Boms { get; set; }
    }
}
