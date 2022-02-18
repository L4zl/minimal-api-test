using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Old200BomreasonForHold
    {
        public Old200BomreasonForHold()
        {
            BomcheckedOuts = new HashSet<BomcheckedOut>();
            Boms = new HashSet<Bom>();
        }

        public long BomreasonForHoldId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BomcheckedOut> BomcheckedOuts { get; set; }
        public virtual ICollection<Bom> Boms { get; set; }
    }
}
