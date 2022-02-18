using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderEntryType
    {
        public SoporderEntryType()
        {
            UserDefaultWarehouses = new HashSet<UserDefaultWarehouse>();
        }

        public long SoporderEntryTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<UserDefaultWarehouse> UserDefaultWarehouses { get; set; }
    }
}
