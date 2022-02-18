using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdocTransmissionMethod
    {
        public SysdocTransmissionMethod()
        {
            PlsupplierDocuments = new HashSet<PlsupplierDocument>();
            SlcustomerDocuments = new HashSet<SlcustomerDocument>();
        }

        public long SysdocTransmissionMethodId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlsupplierDocument> PlsupplierDocuments { get; set; }
        public virtual ICollection<SlcustomerDocument> SlcustomerDocuments { get; set; }
    }
}
