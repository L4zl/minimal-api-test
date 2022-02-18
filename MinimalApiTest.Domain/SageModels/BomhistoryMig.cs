using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomhistoryMig
    {
        public long BomhistoryId { get; set; }
        public long Bomid { get; set; }
        public long StockItemId { get; set; }
        public string BomshortName { get; set; } = null!;
        public string? Bomversion { get; set; }
        public string StockItemCode { get; set; } = null!;
        public string Operation { get; set; } = null!;
        public string OperatedByUserName { get; set; } = null!;
        public DateTime OperatedOnDate { get; set; }
        public DateTime? OperatedOnTime { get; set; }
        public string? Remark { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
