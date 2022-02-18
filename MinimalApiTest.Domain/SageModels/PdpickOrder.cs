using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PdpickOrder
    {
        public long PdpickOrderId { get; set; }
        public long PdpickId { get; set; }
        public long SoporderReturnId { get; set; }
        public long? PddespatchId { get; set; }
    }
}
