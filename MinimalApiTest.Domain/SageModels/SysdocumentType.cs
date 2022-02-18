using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdocumentType
    {
        public SysdocumentType()
        {
            PlsupplierDocuments = new HashSet<PlsupplierDocument>();
            SlcustomerDocuments = new HashSet<SlcustomerDocument>();
            SysdocumentLayoutVersions = new HashSet<SysdocumentLayoutVersion>();
        }

        public long SysdocumentTypeId { get; set; }
        public long UsedInSysmoduleId { get; set; }
        public string Name { get; set; } = null!;
        public long? SystraderContactRoleId { get; set; }
        public bool IsMandatory { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystraderContactRole? SystraderContactRole { get; set; }
        public virtual Sysmodule UsedInSysmodule { get; set; } = null!;
        public virtual ICollection<PlsupplierDocument> PlsupplierDocuments { get; set; }
        public virtual ICollection<SlcustomerDocument> SlcustomerDocuments { get; set; }
        public virtual ICollection<SysdocumentLayoutVersion> SysdocumentLayoutVersions { get; set; }
    }
}
