using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderSiconAppointment
    {
        public long SiconHmorderSiconAppointmentId { get; set; }
        public long SiconHmorderId { get; set; }
        public long SiconAppointmentId { get; set; }
        public long SiconHmorderLineId { get; set; }
        public string? AppointmentType { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
