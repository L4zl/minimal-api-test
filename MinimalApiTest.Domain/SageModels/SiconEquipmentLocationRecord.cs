using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipmentLocationRecord
    {
        public long SiconEquipmentLocationRecordId { get; set; }
        public long SiconEquipmentId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
