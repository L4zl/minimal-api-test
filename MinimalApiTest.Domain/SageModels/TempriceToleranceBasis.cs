using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TempriceToleranceBasis
    {
        public TempriceToleranceBasis()
        {
            Temsettings = new HashSet<Temsetting>();
        }

        public long TempriceToleranceBasisId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Temsetting> Temsettings { get; set; }
    }
}
