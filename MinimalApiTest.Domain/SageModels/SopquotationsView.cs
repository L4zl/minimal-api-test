using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopquotationsView
    {
        public long MmssoqsDocumentTypeId { get; set; }
        public string MmssoqsQuoteDocumentNo { get; set; } = null!;
        public DateTime? MmssoqsDocumentDate { get; set; }
        public DateTime? MmssoqsPromisedDeliveryDate { get; set; }
        public string MmssoqsDocumentCreatedBy { get; set; } = null!;
        public DateTime? MmssoqsRequestedDeliveryDate { get; set; }
        public double? MmssoqsTotalNetValue { get; set; }
        public double? MmssoqsTotalTaxValue { get; set; }
        public double? MmssoqsTotalGrossValue { get; set; }
        public double? MmssoqsTotalGrossValueIncSett { get; set; }
        public string? MmssoqsStatus { get; set; }
        public string MmssoqsCustomerDocumentNo { get; set; } = null!;
        public string MmssoqsSourceDocumentNo { get; set; } = null!;
        public string MmssoqsCustomerAccountNumber { get; set; } = null!;
        public long MmssoqsSoporderReturnId { get; set; }
        public long MmssoqsSlcustomerAccountId { get; set; }
        public string MmssoqsExternalReference { get; set; } = null!;
    }
}
