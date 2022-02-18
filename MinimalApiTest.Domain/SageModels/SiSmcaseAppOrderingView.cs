using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseAppOrderingView
    {
        public long? SiSmcaseId { get; set; }
        public long SiconappointmentId { get; set; }
        public int? NumberForCase { get; set; }
    }
}
