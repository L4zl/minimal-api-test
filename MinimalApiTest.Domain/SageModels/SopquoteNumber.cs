using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopquoteNumber
    {
        public long SopquoteNumberId { get; set; }
        public long NextSopquoteNumber { get; set; }
    }
}
