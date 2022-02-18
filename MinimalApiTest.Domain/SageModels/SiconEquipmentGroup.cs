using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEquipmentGroup
    {
        public long SiconEquipmentGroupId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public long? SiconSubLocationId { get; set; }
        public long? SiconContractId { get; set; }
        public long? SiconContractLineId { get; set; }
        public long? BranchId { get; set; }
    }
}
