using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmaptTimeBooking
    {
        public long SiSmaptTimeBookingId { get; set; }
        public long SiconAppointmentId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? CostingHours { get; set; }
        public decimal? ChargingHours { get; set; }
        public DateTime Date { get; set; }
        public bool? IsBilled { get; set; }
        public long? ChargeRate { get; set; }
        public bool? IsEstimate { get; set; }
        public string MobileId { get; set; } = null!;
    }
}
