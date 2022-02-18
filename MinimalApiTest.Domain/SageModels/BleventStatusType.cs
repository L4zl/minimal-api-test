using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BleventStatusType
    {
        public BleventStatusType()
        {
            Blevents = new HashSet<Blevent>();
        }

        public long BleventStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Blevent> Blevents { get; set; }
    }
}
