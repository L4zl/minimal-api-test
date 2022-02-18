using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPoplineFulfilment
    {
        public long SiconDistPoplineFulfilmentId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? PoporderFulfilmentMethodId { get; set; }
        public string? PoporderFulfilmentMethodName { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
