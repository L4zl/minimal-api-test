﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseWarehouseItem
    {
        public long MseWarehouseItemId { get; set; }
        public long WarehouseItemId { get; set; }
        public bool IsDefaultWorksOrderWarehouse { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
