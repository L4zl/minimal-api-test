using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomlineType
    {
        public BomlineType()
        {
            BomlineCheckedOuts = new HashSet<BomlineCheckedOut>();
            Bomlines = new HashSet<Bomline>();
        }

        public long BomlineTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<BomlineCheckedOut> BomlineCheckedOuts { get; set; }
        public virtual ICollection<Bomline> Bomlines { get; set; }
    }
}
