using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WriteOffCategory
    {
        public long WriteOffCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public long NominalCodeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual NlnominalAccount NominalCode { get; set; } = null!;
    }
}
