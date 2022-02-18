using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BlbillTemplate
    {
        public BlbillTemplate()
        {
            BlbillTemplateClauses = new HashSet<BlbillTemplateClause>();
            PcprojectItems = new HashSet<PcprojectItem>();
        }

        public long BlbillTemplateId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BlbillTemplateClause> BlbillTemplateClauses { get; set; }
        public virtual ICollection<PcprojectItem> PcprojectItems { get; set; }
    }
}
