using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscreditBureau
    {
        public SyscreditBureau()
        {
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
        }

        public long SyscreditBureauId { get; set; }
        public string Name { get; set; } = null!;
        public string WebSite { get; set; } = null!;
        public string CheckingUrl { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
    }
}
