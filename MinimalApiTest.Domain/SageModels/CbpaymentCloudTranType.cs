using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbpaymentCloudTranType
    {
        public CbpaymentCloudTranType()
        {
            CbpaymentCloudTrans = new HashSet<CbpaymentCloudTran>();
        }

        public long CbpaymentCloudTranTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbpaymentCloudTran> CbpaymentCloudTrans { get; set; }
    }
}
