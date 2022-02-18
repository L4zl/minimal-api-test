using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CpcardProcessorTranType
    {
        public CpcardProcessorTranType()
        {
            Cptrans = new HashSet<Cptran>();
        }

        public long CpcardProcessorTranTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Cptran> Cptrans { get; set; }
    }
}
