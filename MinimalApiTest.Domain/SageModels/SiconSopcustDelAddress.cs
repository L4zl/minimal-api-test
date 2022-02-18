using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSopcustDelAddress
    {
        public long SiconSopcustDelAddressId { get; set; }
        public long SoporderReturnId { get; set; }
        public long CustDeliveryAddressId { get; set; }
    }
}
