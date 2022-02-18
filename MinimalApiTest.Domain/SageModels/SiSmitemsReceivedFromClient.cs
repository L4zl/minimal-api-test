using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmitemsReceivedFromClient
    {
        public long SiSmitemsReceivedFromClientId { get; set; }
        public long SiSmcaseId { get; set; }
        public string? ItemReceived { get; set; }
    }
}
