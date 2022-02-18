using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcPlannedPurchaseHistory
    {
        public long SiJcPlannedPurchaseHistoryId { get; set; }
        public long? SiJcPlannedPurchaseId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public int? HistoryTypeId { get; set; }
        public string? UserId { get; set; }
        public DateTime? HistoryDateTime { get; set; }
        public string? Description { get; set; }
    }
}
