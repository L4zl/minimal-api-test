using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsCsvformatHeader
    {
        public long SiconDdsCsvformatHeaderId { get; set; }
        public string Name { get; set; } = null!;
        public bool FixedWidth { get; set; }
        public int TotalLength { get; set; }
        public bool OutputColumnCaptions { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
