using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopprintEuzeroRatedSalesOption
    {
        public SopprintEuzeroRatedSalesOption()
        {
            Sopsettings = new HashSet<Sopsetting>();
        }

        public long SopprintEuzeroRatedSalesOptionId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Sopsetting> Sopsettings { get; set; }
    }
}
