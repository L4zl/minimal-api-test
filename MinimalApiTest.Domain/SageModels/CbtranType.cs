using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbtranType
    {
        public CbtranType()
        {
            CbpendAccountTrans = new HashSet<CbpendAccountTran>();
            CbpostedAccountTrans = new HashSet<CbpostedAccountTran>();
        }

        public long CbtranTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string ShortName { get; set; } = null!;

        public virtual ICollection<CbpendAccountTran> CbpendAccountTrans { get; set; }
        public virtual ICollection<CbpostedAccountTran> CbpostedAccountTrans { get; set; }
    }
}
