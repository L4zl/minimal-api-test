using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmhistory
    {
        public long SiconCrmhistoryId { get; set; }
        public string HistoryKey { get; set; } = null!;
        public string ParentType { get; set; } = null!;
        public long ParentId { get; set; }
        public string? ChildType { get; set; }
        public long? ChildId { get; set; }
        public DateTime? HistoryDateTime { get; set; }
        public string HistoryUsername { get; set; } = null!;
        public short HistoryTypeId { get; set; }
        public string HistoryTypeDescription { get; set; } = null!;
        public string HistoryDescription { get; set; } = null!;
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
    }
}
