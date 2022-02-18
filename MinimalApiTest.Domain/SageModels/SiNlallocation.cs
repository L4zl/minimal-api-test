using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiNlallocation
    {
        public long SiNlallocationId { get; set; }
        public long NlnominalAccountId { get; set; }
        public DateTime? AllocationDate { get; set; }
        public int? UserNumber { get; set; }
        public DateTime? DateTimeCreated { get; set; }
        public decimal? CreditTotal { get; set; }
        public decimal? DebitTotal { get; set; }
        public string? Reference { get; set; }
    }
}
