using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAppointmentResource
    {
        public long SiconAppointmentResourceId { get; set; }
        public long SiconResourceId { get; set; }
        public long SiconAppointmentId { get; set; }
        public long? SiJctrnId { get; set; }
    }
}
