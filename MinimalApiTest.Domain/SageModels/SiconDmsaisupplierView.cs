using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsaisupplierView
    {
        public long PlsupplierAccountId { get; set; }
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public long? AiapplicationId { get; set; }
        public long? SiconDmssupplierId { get; set; }
        public long? AisupplierId { get; set; }
        public bool Aienabled { get; set; }
        public bool? AiorderNumberMatching { get; set; }
        public bool? AijobNumberMatching { get; set; }
        public bool? Aipogrnvalidation { get; set; }
        public bool? AiitemLineExtraction { get; set; }
        public string? VatCodeZeroVatInvoices { get; set; }
        public bool? SecondReferenceValidation { get; set; }
        public bool? AireceiveInvoiceImagesOnly { get; set; }
    }
}
