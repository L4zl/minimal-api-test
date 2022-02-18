using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TemmessageType
    {
        public TemmessageType()
        {
            Temmessages = new HashSet<Temmessage>();
        }

        public long TemmessageTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Temmessage> Temmessages { get; set; }
    }
}
