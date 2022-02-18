using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAuthorisedNominal
    {
        public long SiconAuthorisedNominalId { get; set; }
        public long NominalCodeId { get; set; }
        public bool Authorised { get; set; }
    }
}
