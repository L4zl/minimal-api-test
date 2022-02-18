using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Nldepartment
    {
        public Nldepartment()
        {
            NlnominalAccounts = new HashSet<NlnominalAccount>();
        }

        public long NldepartmentId { get; set; }
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string ContactName { get; set; } = null!;
        public string ContactDetails { get; set; } = null!;
        public string ContactEmailAddress { get; set; } = null!;

        public virtual ICollection<NlnominalAccount> NlnominalAccounts { get; set; }
    }
}
