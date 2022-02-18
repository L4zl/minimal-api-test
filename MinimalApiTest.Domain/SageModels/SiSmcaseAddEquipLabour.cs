using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseAddEquipLabour
    {
        public long SiSmcaseAddEquipLabourId { get; set; }
        public long? SiconEquipmentCaseId { get; set; }
        public long SiSmcaseAdditionalLabourId { get; set; }
        public decimal Quantity { get; set; }

        public virtual SiconEquipmentCase? SiconEquipmentCase { get; set; }
    }
}
