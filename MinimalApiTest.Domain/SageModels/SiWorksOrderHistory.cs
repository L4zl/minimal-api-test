using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderHistory
    {
        public long SiWorksOrderHistoryId { get; set; }
        public long SiWorksOrderId { get; set; }
        public DateTime? DateTimeOfChange { get; set; }
        public string? User { get; set; }
        public long HistoryType { get; set; }
        public string? ChangeFrom { get; set; }
        public string? ChangeTo { get; set; }
        public string? Reason { get; set; }
        public long? Id { get; set; }
    }
}
