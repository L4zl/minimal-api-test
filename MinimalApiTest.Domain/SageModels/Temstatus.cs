using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Temstatus
    {
        public Temstatus()
        {
            Temmessages = new HashSet<Temmessage>();
        }

        public long TemstatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Temmessage> Temmessages { get; set; }
    }
}
