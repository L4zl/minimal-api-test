using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsCsvserialNumber
    {
        public long SiconDdsCsvserialNumberId { get; set; }
        public long? SiconDdsCsvformatHeaderId { get; set; }
        public int SerialNumber { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
