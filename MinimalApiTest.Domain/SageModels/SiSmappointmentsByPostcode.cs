using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmappointmentsByPostcode
    {
        public long SiconAppointmentId { get; set; }
        public long SiSmcaseId { get; set; }
        public string? LocationPostcode { get; set; }
        public long? SiSmdocumentStatusId { get; set; }
        public string? CaseNumber { get; set; }
        public bool? Confirmed { get; set; }
        public string CustomerAccountName { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public DateTime? StartDateOnly { get; set; }
    }
}
