using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Temlocation
    {
        public Temlocation()
        {
            Temmessages = new HashSet<Temmessage>();
        }

        public long TemlocationId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Temmessage> Temmessages { get; set; }
    }
}
