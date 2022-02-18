using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SobackToBackPoview
    {
        public string MmssoboSodocumentNo { get; set; } = null!;
        public string MmssoboPodocumentNo { get; set; } = null!;
        public string MmssoboStockItem { get; set; } = null!;
        public double? MmssoboLineQuantity { get; set; }
        public string MmssoboSupplierName { get; set; } = null!;
        public double? MmssoboReqDelQuantity { get; set; }
        public DateTime? MmssoboReqDelDate { get; set; }
        public long MmssoboOrderReturnId { get; set; }
        public DateTime? MmssoboOrderDate { get; set; }
    }
}
