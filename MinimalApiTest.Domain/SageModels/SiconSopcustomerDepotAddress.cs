using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSopcustomerDepotAddress
    {
        public long SiconSopcustomerDepotAddressId { get; set; }
        public long SoporderReturnId { get; set; }
        public long? SiconDepotAddressId { get; set; }
    }
}
