using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractDeferredTran
    {
        public long SiconContractDeferredTranId { get; set; }
        public long? SiconContractId { get; set; }
        public long? SiconContractLineId { get; set; }
        public long? SiconContractDeferredId { get; set; }
        public long? TransactionTypeId { get; set; }
        public string? LineDescription { get; set; }
        public decimal? Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string? TransactionStatus { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public long? DeferredNlaccountId { get; set; }
        public long? PostingNlaccountId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public long? SoporderReturnId { get; set; }
        public string? PaidStatus { get; set; }
        public string? NewExistingStatus { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public string? LastUpdatedByUser { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public long? SopinvoiceCreditLineId { get; set; }
        public bool? HideSoinJcbutShowDeferred { get; set; }
        public long? SiconContractLineSupplierId { get; set; }
    }
}
