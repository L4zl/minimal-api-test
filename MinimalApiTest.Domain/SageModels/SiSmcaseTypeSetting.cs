using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseTypeSetting
    {
        public long SiSmcaseTypeSettingId { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public bool? AutoAppointmentConfirmEmails { get; set; }
        public bool? EquipmentTab { get; set; }
        public bool? PartsTab { get; set; }
        public bool? OtherCostsTab { get; set; }
        public bool? BillingInfoTab { get; set; }
        public bool? BillingSummaryTab { get; set; }
        public bool? QuotesTab { get; set; }
    }
}
