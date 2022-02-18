using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PoponOrderLine
    {
        public long PoponOrderLineId { get; set; }
        public long PoporderReturnLineId { get; set; }
        public decimal OnOrderQuantity { get; set; }
        public DateTime? OnOrderDate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public long PoponOrderBalanceId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal StockUnitOnOrderQuantity { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PoponOrderBalance PoponOrderBalance { get; set; } = null!;
        public virtual PoporderReturnLine PoporderReturnLine { get; set; } = null!;
    }
}
