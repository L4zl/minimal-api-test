using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NatureOfTransCode
    {
        public NatureOfTransCode()
        {
            IntrastatEntries = new HashSet<IntrastatEntry>();
            Popsettings = new HashSet<Popsetting>();
            Sopsettings = new HashSet<Sopsetting>();
        }

        public long NatureOfTransCodeId { get; set; }
        public string Code { get; set; } = null!;
        public long? CountryCodeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SyscountryCode? CountryCode { get; set; }
        public virtual ICollection<IntrastatEntry> IntrastatEntries { get; set; }
        public virtual ICollection<Popsetting> Popsettings { get; set; }
        public virtual ICollection<Sopsetting> Sopsettings { get; set; }
    }
}
