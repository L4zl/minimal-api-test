using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MseContactValue
    {
        public long MseContactValueId { get; set; }
        public long SyscontactTypeId { get; set; }
        public long MseContactId { get; set; }
        public string ContactValue { get; set; } = null!;
        public bool IsPreferred { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string ContactValueCountryCode { get; set; } = null!;
        public string ContactValueAreaCode { get; set; } = null!;
        public string ContactValueSubscriberNumber { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual MseContact MseContact { get; set; } = null!;
    }
}
