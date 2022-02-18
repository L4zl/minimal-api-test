using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopdespatchReceiptType
    {
        public SopdespatchReceiptType()
        {
            SopdespatchReceipts = new HashSet<SopdespatchReceipt>();
        }

        public long SopdespatchReceiptTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SopdespatchReceipt> SopdespatchReceipts { get; set; }
    }
}
