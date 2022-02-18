using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxTranType
    {
        public SystaxTranType()
        {
            SystaxTrans = new HashSet<SystaxTran>();
        }

        public long SystaxTranTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SystaxTran> SystaxTrans { get; set; }
    }
}
