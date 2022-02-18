using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierDocument
    {
        public long PlsupplierDocumentId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long SysdocumentTypeId { get; set; }
        public long SysdocTransmissionMethodId { get; set; }
        public long? SendToPlsupplierLocationId { get; set; }
        public long SysdocumentLayoutVersionId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? SendToPlsuppContactValueId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
        public virtual PlsupplierContactValue? SendToPlsuppContactValue { get; set; }
        public virtual PlsupplierLocation? SendToPlsupplierLocation { get; set; }
        public virtual SysdocTransmissionMethod SysdocTransmissionMethod { get; set; } = null!;
        public virtual SysdocumentLayoutVersion SysdocumentLayoutVersion { get; set; } = null!;
        public virtual SysdocumentType SysdocumentType { get; set; } = null!;
    }
}
