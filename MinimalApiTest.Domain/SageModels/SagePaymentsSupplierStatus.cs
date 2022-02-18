using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SagePaymentsSupplierStatus
    {
        public SagePaymentsSupplierStatus()
        {
            Nlsettings = new HashSet<Nlsetting>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
        }

        public long SagePaymentsSupplierStatusId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<Nlsetting> Nlsettings { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
    }
}
