using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractDeferred
    {
        public long SiconContractDeferredId { get; set; }
        public long SiconContractId { get; set; }
        public string? ContractDescription { get; set; }
        public decimal? TotalAmountToDefer { get; set; }
        public decimal? TotalTransfered { get; set; }
        public string? DeferredStatus { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SiconContractLineSupplierId { get; set; }
        public long? SupplierInvoiceUrn { get; set; }
    }
}
