using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmcollectionLine
    {
        public long SiconHmcollectionLineId { get; set; }
        public DateTime? OffHireDate { get; set; }
        public long SiconHmorderLineAssetsLineId { get; set; }
        public long SiconHmcollectionNoteId { get; set; }
        public decimal? QuantityToReceive { get; set; }
    }
}
