using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Sopuser
    {
        public Sopuser()
        {
            UserDefaultWarehouses = new HashSet<UserDefaultWarehouse>();
        }

        public long SopuserId { get; set; }
        public int UserNumber { get; set; }

        public virtual SopuserPermission SopuserPermission { get; set; } = null!;
        public virtual ICollection<UserDefaultWarehouse> UserDefaultWarehouses { get; set; }
    }
}
