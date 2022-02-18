using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class DocumentProcessStatus
    {
        public DocumentProcessStatus()
        {
            SoporderReturnAllocatedStatuses = new HashSet<SoporderReturn>();
            SoporderReturnArchAllocatedStatuses = new HashSet<SoporderReturnArch>();
            SoporderReturnArchCancelledStatuses = new HashSet<SoporderReturnArch>();
            SoporderReturnArchDespatchReceiptStatuses = new HashSet<SoporderReturnArch>();
            SoporderReturnArchInvoiceCreditStatuses = new HashSet<SoporderReturnArch>();
            SoporderReturnCancelledStatuses = new HashSet<SoporderReturn>();
            SoporderReturnDespatchReceiptStatuses = new HashSet<SoporderReturn>();
            SoporderReturnInvoiceCreditStatuses = new HashSet<SoporderReturn>();
        }

        public long DocumentProcessStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SoporderReturn> SoporderReturnAllocatedStatuses { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArchAllocatedStatuses { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArchCancelledStatuses { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArchDespatchReceiptStatuses { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArchInvoiceCreditStatuses { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturnCancelledStatuses { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturnDespatchReceiptStatuses { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturnInvoiceCreditStatuses { get; set; }
    }
}
