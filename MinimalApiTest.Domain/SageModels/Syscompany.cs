using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Syscompany
    {
        public Syscompany()
        {
            SyscompanyLocations = new HashSet<SyscompanyLocation>();
        }

        public long SyscompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? TaxRegistrationNumber { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string? SagePaymentsDatasetIdentifier { get; set; }
        public DateTime? SagePaymentsLastSyncDateTime { get; set; }
        public string? SagePaymentsTag { get; set; }
        public long? EdulocalEducationAuthorityId { get; set; }
        public long EduschoolTypeId { get; set; }
        public bool IsAcademy { get; set; }
        public string BankCloudCompanyId { get; set; } = null!;
        public string PaymentCloudCompanyId { get; set; } = null!;
        public string Eorinumber { get; set; } = null!;

        public virtual EdulocalEducationAuthority? EdulocalEducationAuthority { get; set; }
        public virtual EduschoolType EduschoolType { get; set; } = null!;
        public virtual ICollection<SyscompanyLocation> SyscompanyLocations { get; set; }
    }
}
