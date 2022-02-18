using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobHireHistory
    {
        public long SiconJobHireHistoryId { get; set; }
        public long? SiconJobHireId { get; set; }
        public int? HistoryTypeId { get; set; }
        public string? UserId { get; set; }
        public DateTime? HistoryDateTime { get; set; }
        public string? Description { get; set; }
    }
}
