using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlfactorHouseContact
    {
        public long PlfactorHouseContactId { get; set; }
        public long PlfactorHouseId { get; set; }
        public string ContactAddress { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public long SyscontactTypeId { get; set; }
        public string Description { get; set; } = null!;
        public bool IsPrimary { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlfactorHouse PlfactorHouse { get; set; } = null!;
        public virtual SyscontactType SyscontactType { get; set; } = null!;
    }
}
