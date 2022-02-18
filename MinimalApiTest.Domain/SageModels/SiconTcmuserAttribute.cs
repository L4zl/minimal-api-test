using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmuserAttribute
    {
        public long SiconTcmuserAttributeId { get; set; }
        public long SiconTcmattributeId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public long? SiconTcmuserId { get; set; }
    }
}
