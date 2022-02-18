using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmaptResTimeBooking
    {
        public long SiSmaptResTimeBookingId { get; set; }
        public long SiSmaptTimeBookingId { get; set; }
        public long SiconEmployeeId { get; set; }
    }
}
