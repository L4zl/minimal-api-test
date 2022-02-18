using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHistory
    {
        public long SiconHistoryId { get; set; }
        public string? ParentType { get; set; }
        public long? ParentId { get; set; }
        public DateTime? HistoryDate { get; set; }
        public string? UserName { get; set; }
        public string? HistoryType { get; set; }
        public string? Description { get; set; }
    }
}
