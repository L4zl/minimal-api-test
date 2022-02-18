using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysproviderTypeAttributeType
    {
        public SysproviderTypeAttributeType()
        {
            SysproviderTypeAttributes = new HashSet<SysproviderTypeAttribute>();
        }

        public long SysproviderTypeAttributeTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SysproviderTypeAttribute> SysproviderTypeAttributes { get; set; }
    }
}
