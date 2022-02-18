﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopcancelledLineArch
    {
        public long PopcancelledLineId { get; set; }
        public long PoporderReturnId { get; set; }
        public string ItemCode { get; set; } = null!;
        public decimal CancelledQuantity { get; set; }
        public DateTime? CancelledDate { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string BuyingUnitDescription { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal StockUnitCancelledQuantity { get; set; }
        public string ItemDescription { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PoporderReturnArch PoporderReturn { get; set; } = null!;
    }
}