using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmlabourOnEquipmentCase
    {
        public long SiSmlabourOnEquipmentCaseId { get; set; }
        public long? SiconEquipmentCaseId { get; set; }
        public decimal? Quantity { get; set; }
        public long? SiSmaptTimeBookingId { get; set; }
        public long? SiconAppointmentId { get; set; }

        public virtual SiconEquipmentCase? SiconEquipmentCase { get; set; }
    }
}
