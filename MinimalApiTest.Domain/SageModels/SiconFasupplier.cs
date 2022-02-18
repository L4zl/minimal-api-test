using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFasupplier
    {
        public long SupplierId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string SupplierAccountName { get; set; } = null!;
        public string SupplierAccountNumber { get; set; } = null!;
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? PostCode { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactNumber { get; set; }
        public bool Removed { get; set; }
    }
}
