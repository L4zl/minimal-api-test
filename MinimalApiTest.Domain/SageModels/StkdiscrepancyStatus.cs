using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class StkdiscrepancyStatus
    {
        public StkdiscrepancyStatus()
        {
            StocktakeCountSheetItems = new HashSet<StocktakeCountSheetItem>();
        }

        public long StkdiscrepancyStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<StocktakeCountSheetItem> StocktakeCountSheetItems { get; set; }
    }
}
