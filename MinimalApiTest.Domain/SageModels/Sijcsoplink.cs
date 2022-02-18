using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Sijcsoplink
    {
        public long SijcsoplinkId { get; set; }
        public long? SoporderReturnId { get; set; }
        public bool? IsProcessed { get; set; }
    }
}
