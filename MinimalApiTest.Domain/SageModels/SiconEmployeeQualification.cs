using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEmployeeQualification
    {
        public long SiJcEmpQualificationId { get; set; }
        public long? SiJcEmpId { get; set; }
        public long? SiJcQualificationId { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
