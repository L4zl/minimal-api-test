using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiPopsupplierAddress
    {
        public long SiPopsupplierAddressId { get; set; }
        public long PoporderReturnId { get; set; }
        public long SiSupplierAddressId { get; set; }
    }
}
