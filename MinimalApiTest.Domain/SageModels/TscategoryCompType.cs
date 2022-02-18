using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TscategoryCompType
    {
        public TscategoryCompType()
        {
            TscategoryComponents = new HashSet<TscategoryComponent>();
        }

        public long TscategoryComponentTypeId { get; set; }
        public string Description { get; set; } = null!;

        public virtual ICollection<TscategoryComponent> TscategoryComponents { get; set; }
    }
}
