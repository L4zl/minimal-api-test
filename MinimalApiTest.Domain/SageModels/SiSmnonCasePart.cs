using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmnonCasePart
    {
        public long SiSmnonCasePartId { get; set; }
        public long? ItemId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? Quantity { get; set; }
        public string? IdentificationNo { get; set; }
        public string? Description { get; set; }
        public long? SiconEquipmentId { get; set; }

        public virtual SiconEquipment? SiconEquipment { get; set; }
    }
}
