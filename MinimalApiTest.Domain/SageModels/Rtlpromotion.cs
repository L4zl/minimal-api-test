using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Rtlpromotion
    {
        public long PromoId { get; set; }
        public string? PromoCode { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal RewardValue { get; set; }
        public string? LastAmendUser { get; set; }
        public DateTime? LastAmendDateTime { get; set; }
        public long? RewardTypeId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
    }
}
