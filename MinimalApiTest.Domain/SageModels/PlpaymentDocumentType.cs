using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlpaymentDocumentType
    {
        public PlpaymentDocumentType()
        {
            PlpaymentGroups = new HashSet<PlpaymentGroup>();
        }

        public long PlpaymentDocumentTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlpaymentGroup> PlpaymentGroups { get; set; }
    }
}
