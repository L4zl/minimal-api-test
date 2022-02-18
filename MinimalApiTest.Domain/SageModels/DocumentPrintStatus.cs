using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DocumentPrintStatus
    {
        public DocumentPrintStatus()
        {
            PoporderReturnArches = new HashSet<PoporderReturnArch>();
            PoporderReturns = new HashSet<PoporderReturn>();
            SopallocationLines = new HashSet<SopallocationLine>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
        }

        public long DocumentPrintStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoporderReturnArch> PoporderReturnArches { get; set; }
        public virtual ICollection<PoporderReturn> PoporderReturns { get; set; }
        public virtual ICollection<SopallocationLine> SopallocationLines { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
    }
}
