using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopordersView
    {
        public long MmssoosDocumentTypeId { get; set; }
        public string MmssoosOrderDocumentNo { get; set; } = null!;
        public DateTime? MmssoosDocumentDate { get; set; }
        public DateTime? MmssoosPromisedDeliveryDate { get; set; }
        public string MmssoosDocumentCreatedBy { get; set; } = null!;
        public DateTime? MmssoosRequestedDeliveryDate { get; set; }
        public double? MmssoosTotalNetValue { get; set; }
        public double? MmssoosTotalTaxValue { get; set; }
        public double? MmssoosTotalGrossValue { get; set; }
        public double? MmssoosTotalGrossValueIncSett { get; set; }
        public string? MmssoosStatus { get; set; }
        public string MmssoosCustomerDocumentNo { get; set; } = null!;
        public string MmssoosSourceDocumentNo { get; set; } = null!;
        public string MmssoosCustomerAccountNumber { get; set; } = null!;
        public long MmssoosSoporderReturnId { get; set; }
        public long MmssoosSlcustomerAccountId { get; set; }
        public string MmssoosExternalReference { get; set; } = null!;
    }
}
