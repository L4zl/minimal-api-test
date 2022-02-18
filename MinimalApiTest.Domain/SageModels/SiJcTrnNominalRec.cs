using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcTrnNominalRec
    {
        public long SiJcTrnNominalRecId { get; set; }
        public long? SiJcTrnId { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public long? NlpostedNominalTranId { get; set; }
        public DateTime? LinkDateTime { get; set; }
        public bool? IsManualLink { get; set; }
        public string? DeletedUser { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public decimal? LineValue { get; set; }
        public bool? IsCompletedJob { get; set; }
        public string? OriginalNarrative { get; set; }
        public int? Nllocation { get; set; }
        public long? NlpendingNominalTranId { get; set; }
        public long? NldeferredNominalTranId { get; set; }
    }
}
