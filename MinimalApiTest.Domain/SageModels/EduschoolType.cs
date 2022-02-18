using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class EduschoolType
    {
        public EduschoolType()
        {
            Syscompanies = new HashSet<Syscompany>();
        }

        public long EduschoolTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<Syscompany> Syscompanies { get; set; }
    }
}
