using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabstocktakeOption
    {
        public long SiconWabstocktakeOptionsId { get; set; }
        public long StocktakeId { get; set; }
        public long? InternalAreaId { get; set; }
    }
}
