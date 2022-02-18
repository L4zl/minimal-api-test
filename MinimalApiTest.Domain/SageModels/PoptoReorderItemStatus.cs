using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoptoReorderItemStatus
    {
        public PoptoReorderItemStatus()
        {
            PoptoReorderItems = new HashSet<PoptoReorderItem>();
        }

        public long PoptoReorderItemStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PoptoReorderItem> PoptoReorderItems { get; set; }
    }
}
