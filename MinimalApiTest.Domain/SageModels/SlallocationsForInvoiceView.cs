using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlallocationsForInvoiceView
    {
        public DateTime? MmssiaAllocationDate { get; set; }
        public string? MmssiaUserName { get; set; }
        public long? MmssiaSlcustomerAccountId { get; set; }
        public string? MmssiaAllocationType { get; set; }
        public double? MmssiaAllocationValue { get; set; }
        public string? MmssiaTransactionReference { get; set; }
        public string? MmssiaTransactionType { get; set; }
        public string? MmssiaInvoiceRef { get; set; }
        public long? MmssiaUrn { get; set; }
        public string? MmssiaSource { get; set; }
        public double? MmssiaValue { get; set; }
    }
}
