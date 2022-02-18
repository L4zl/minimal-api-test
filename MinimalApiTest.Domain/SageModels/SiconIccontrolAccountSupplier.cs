using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIccontrolAccountSupplier
    {
        public long SiconIccontrolAccountSupId { get; set; }
        public long? SiconIccontrolAccountId { get; set; }
        public long? SyscurrencyId { get; set; }
        public string Isocode { get; set; } = null!;
        public long? SupplierId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string LastUpdatedByUser { get; set; } = null!;
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
