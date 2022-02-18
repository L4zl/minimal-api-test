using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderReturnType
    {
        public SoporderReturnType()
        {
            SoporderReturnArchDocumentTypes = new HashSet<SoporderReturnArch>();
            SoporderReturnArchSourceTypes = new HashSet<SoporderReturnArch>();
            SoporderReturnDocumentTypes = new HashSet<SoporderReturn>();
            SoporderReturnSourceTypes = new HashSet<SoporderReturn>();
        }

        public long SoporderReturnTypeId { get; set; }
        public string SoporderReturnTypeName { get; set; } = null!;

        public virtual ICollection<SoporderReturnArch> SoporderReturnArchDocumentTypes { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArchSourceTypes { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturnDocumentTypes { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturnSourceTypes { get; set; }
    }
}
