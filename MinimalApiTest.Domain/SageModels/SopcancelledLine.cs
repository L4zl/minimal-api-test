using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopcancelledLine
    {
        public long SopcancelledLineId { get; set; }
        public long SoporderReturnId { get; set; }
        public string ItemCode { get; set; } = null!;
        public decimal CancelledQuantity { get; set; }
        public DateTime CancelledDate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string SellingUnitDescription { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal StockUnitCancelledQuantity { get; set; }
        public string ItemDescription { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual SoporderReturn SoporderReturn { get; set; } = null!;
    }
}
