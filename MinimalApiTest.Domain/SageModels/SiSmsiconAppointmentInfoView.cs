using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmsiconAppointmentInfoView
    {
        public long SiconAppointmentId { get; set; }
        public int IsCaseAppointment { get; set; }
        public int IsWorkAppointment { get; set; }
        public int IsToTravelAppointment { get; set; }
        public int IsFromTravelAppointment { get; set; }
        public int IsFuture { get; set; }
        public bool? IsWorkComplete { get; set; }
    }
}
