using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillTemplateClause
    {
        public long BlbillTemplateClauseId { get; set; }
        public long BlbillTemplateId { get; set; }
        public long BlclauseId { get; set; }
        public int Sequence { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual BlbillTemplate BlbillTemplate { get; set; } = null!;
        public virtual Blclause Blclause { get; set; } = null!;
    }
}
