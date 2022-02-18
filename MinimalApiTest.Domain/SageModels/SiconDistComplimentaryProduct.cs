using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistComplimentaryProduct
    {
        public long SiconComplimentaryProductId { get; set; }
        public long? ItemId { get; set; }
        public long? ComplimentaryProductId { get; set; }
        public bool Deleted { get; set; }
    }
}
