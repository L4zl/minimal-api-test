using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseContact
    {
        public MseContact()
        {
            MseContactAddresses = new HashSet<MseContactAddress>();
            MseContactValues = new HashSet<MseContactValue>();
            MseProductGroups = new HashSet<MseProductGroup>();
            MseStockItems = new HashSet<MseStockItem>();
            MseWarehouses = new HashSet<MseWarehouse>();
        }

        public long MseContactId { get; set; }
        public string ContactName { get; set; } = null!;
        public string Department { get; set; } = null!;
        public string JobTitle { get; set; } = null!;
        public bool IsDefaultContact { get; set; }
        public string ContactFirstName { get; set; } = null!;
        public string ContactMiddleName { get; set; } = null!;
        public string ContactLastName { get; set; } = null!;
        public long ContactSalutationId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long MseContactRoleId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MseContactRole MseContactRole { get; set; } = null!;
        public virtual ICollection<MseContactAddress> MseContactAddresses { get; set; }
        public virtual ICollection<MseContactValue> MseContactValues { get; set; }
        public virtual ICollection<MseProductGroup> MseProductGroups { get; set; }
        public virtual ICollection<MseStockItem> MseStockItems { get; set; }
        public virtual ICollection<MseWarehouse> MseWarehouses { get; set; }
    }
}
