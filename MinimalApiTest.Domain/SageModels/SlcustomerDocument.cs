﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerDocument
    {
        public long SlcustomerDocumentId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long SysdocumentTypeId { get; set; }
        public long SysdocTransmissionMethodId { get; set; }
        public long? SendToSlcustomerLocationId { get; set; }
        public long SysdocumentLayoutVersionId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? SendToSlcustContactValueId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlcustomerContactValue? SendToSlcustContactValue { get; set; }
        public virtual SlcustomerLocation? SendToSlcustomerLocation { get; set; }
        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
        public virtual SysdocTransmissionMethod SysdocTransmissionMethod { get; set; } = null!;
        public virtual SysdocumentLayoutVersion SysdocumentLayoutVersion { get; set; } = null!;
        public virtual SysdocumentType SysdocumentType { get; set; } = null!;
    }
}
