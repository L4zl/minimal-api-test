using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCispendingVerification
    {
        public long SiconCispendingVerificationId { get; set; }
        public long? SiconCissupplierId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public DateTime? ContVerficationDate { get; set; }
        public DateTime? ContOriginalVerficationDate { get; set; }
        public DateTime? LastReturnDate { get; set; }
        public string? SupplierReference { get; set; }
        public string? SupplierAccountName { get; set; }
        public bool? Verify { get; set; }
    }
}
