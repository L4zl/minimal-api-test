using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BldetailOrSummaryType
    {
        public BldetailOrSummaryType()
        {
            Blclauses = new HashSet<Blclause>();
        }

        public long BldetailOrSummaryTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Blclause> Blclauses { get; set; }
    }
}
