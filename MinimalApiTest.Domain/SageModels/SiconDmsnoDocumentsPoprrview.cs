using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsnoDocumentsPoprrview
    {
        public long PopreceiptReturnId { get; set; }
        public long PopreceiptReturnTypeId { get; set; }
        public string ReceiptTypeName { get; set; } = null!;
        public string ReceiptNo { get; set; } = null!;
        public DateTime? ReceiptDate { get; set; }
        public string ReceiptSupplierDocumentNo { get; set; } = null!;
        public DateTime? ReceiptSupplierDocumentDate { get; set; }
        public string Narrative { get; set; } = null!;
        public long PoporderReturnId { get; set; }
        public long? SupplierId { get; set; }
        public long DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; } = null!;
        public string SupplierAccountNumber { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public string DocumentNo { get; set; } = null!;
        public string SupplierDocumentNo { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public decimal TotalGrossValue { get; set; }
        public string DocumentOriginatorName { get; set; } = null!;
        public string DocumentCreatedBy { get; set; } = null!;
    }
}
