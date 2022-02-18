using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MovementBalanceType
    {
        public MovementBalanceType()
        {
            MovementBalances = new HashSet<MovementBalance>();
        }

        public long MovementBalanceTypeId { get; set; }
        public string MovementBalanceTypeName { get; set; } = null!;

        public virtual ICollection<MovementBalance> MovementBalances { get; set; }
    }
}
