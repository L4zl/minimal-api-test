using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoporderReturnType
    {
        public PoporderReturnType()
        {
            PoporderReturnArchDocumentTypes = new HashSet<PoporderReturnArch>();
            PoporderReturnArchSourceTypes = new HashSet<PoporderReturnArch>();
            PoporderReturnDocumentTypes = new HashSet<PoporderReturn>();
            PoporderReturnSourceTypes = new HashSet<PoporderReturn>();
        }

        public long PoporderReturnTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnArch> PoporderReturnArchDocumentTypes { get; set; }
        public virtual ICollection<PoporderReturnArch> PoporderReturnArchSourceTypes { get; set; }
        public virtual ICollection<PoporderReturn> PoporderReturnDocumentTypes { get; set; }
        public virtual ICollection<PoporderReturn> PoporderReturnSourceTypes { get; set; }
    }
}
