using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopreorderLineStatus
    {
        public PopreorderLineStatus()
        {
            PoptoReorderSoplines = new HashSet<PoptoReorderSopline>();
        }

        public long PopreorderLineStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoptoReorderSopline> PoptoReorderSoplines { get; set; }
    }
}
