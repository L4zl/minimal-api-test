using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class UserDefaultWarehouse
    {
        public long UserDefaultWarehouseId { get; set; }
        public long SopuserId { get; set; }
        public long SoporderEntryTypeId { get; set; }
        public long? WarehouseId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SoporderEntryType SoporderEntryType { get; set; } = null!;
        public virtual Sopuser Sopuser { get; set; } = null!;
        public virtual SopuserPermission SopuserNavigation { get; set; } = null!;
        public virtual Warehouse? Warehouse { get; set; }
    }
}
