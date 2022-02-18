using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmbill
    {
        public long SiconHmbillId { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SiconHmorderId { get; set; }
        public long? SiconHmorderLineId { get; set; }
        public DateTime? ForecastFrom { get; set; }
        public DateTime? ForecastTo { get; set; }
        public bool? IsBillCreditPosted { get; set; }
        public bool? IsCredit { get; set; }
        public long? CreditedSiconHmbillId { get; set; }
        public string? CreditedDocumentNo { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
