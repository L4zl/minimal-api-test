using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmcollectionNote
    {
        public long SiconHmcollectionNoteId { get; set; }
        public string? DocumentNo { get; set; }
        public DateTime? CollectionDate { get; set; }
        public bool? Received { get; set; }
        public long SiconHmorderId { get; set; }
    }
}
