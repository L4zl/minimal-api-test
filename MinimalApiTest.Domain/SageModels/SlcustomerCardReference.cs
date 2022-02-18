using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerCardReference
    {
        public long SlcustomerCardReferenceId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime LastUsedDate { get; set; }
        public string TranCode { get; set; } = null!;
        public string AuthNumber { get; set; } = null!;
        public string SecurityKey { get; set; } = null!;
        public string CardProcessorTranCode { get; set; } = null!;

        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
    }
}
