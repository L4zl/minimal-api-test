using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopreceiptReturnType
    {
        public PopreceiptReturnType()
        {
            PopreceiptReturns = new HashSet<PopreceiptReturn>();
        }

        public long PopreceiptReturnTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PopreceiptReturn> PopreceiptReturns { get; set; }
    }
}
