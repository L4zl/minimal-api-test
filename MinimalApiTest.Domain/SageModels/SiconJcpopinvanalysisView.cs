using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcpopinvanalysisView
    {
        public string? Jobnumber { get; set; }
        public string? PopdocumentNo { get; set; }
        public DateTime? PopdateTimeCreated { get; set; }
        public long? PoplineTypeId { get; set; }
        public long PopinvoiceCreditLineId { get; set; }
        public decimal InvoiceCreditQuantity { get; set; }
        public decimal DiscountedUnitPrice { get; set; }
        public string PopinvoiceCreditNo { get; set; } = null!;
        public DateTime? InvoiceCreditDate { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public decimal EffectiveExchangeRate { get; set; }
        public long? Sijcjobid { get; set; }
        public long Sijctrnid { get; set; }
        public long? PopinvSijctrnid { get; set; }
        public long PlpostedSupplierTranId { get; set; }
    }
}
