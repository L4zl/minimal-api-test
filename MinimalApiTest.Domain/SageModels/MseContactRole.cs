using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseContactRole
    {
        public MseContactRole()
        {
            MseContacts = new HashSet<MseContact>();
        }

        public long MseContactRoleId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MseContact> MseContacts { get; set; }
    }
}
