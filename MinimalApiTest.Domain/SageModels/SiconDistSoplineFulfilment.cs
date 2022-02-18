using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSoplineFulfilment
    {
        public long SiconDistSoplineFulfilmentId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SoporderFulfilmentMethodId { get; set; }
        public string? SoporderFulfilmentMethodName { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
