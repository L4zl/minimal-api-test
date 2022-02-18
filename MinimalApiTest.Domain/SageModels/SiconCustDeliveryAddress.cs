using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCustDeliveryAddress
    {
        public long SiconCustDeliveryAddressId { get; set; }
        public long CustDeliveryAddressId { get; set; }
        public bool? InActive { get; set; }
    }
}
