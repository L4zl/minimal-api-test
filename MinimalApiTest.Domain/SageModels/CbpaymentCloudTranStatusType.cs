using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbpaymentCloudTranStatusType
    {
        public CbpaymentCloudTranStatusType()
        {
            CbpaymentCloudTrans = new HashSet<CbpaymentCloudTran>();
        }

        public long CbpaymentCloudTranStatusTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<CbpaymentCloudTran> CbpaymentCloudTrans { get; set; }
    }
}
