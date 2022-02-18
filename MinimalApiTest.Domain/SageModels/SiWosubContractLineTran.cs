using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWosubContractLineTran
    {
        public long SiWosubContractLineTranId { get; set; }
        public long? SiWosubContractLineId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? PoporderReturnId { get; set; }
        public decimal? DespatchQuantity { get; set; }
        public decimal? ReceivedQuantity { get; set; }
        public DateTime? DespatchDate { get; set; }
        public DateTime? DateReceived { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
