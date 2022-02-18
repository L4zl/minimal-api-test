using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconChecklist
    {
        public long SiconChecklistId { get; set; }
        public long? ParentId { get; set; }
        public string? ParentType { get; set; }
        public string? Description { get; set; }
        public bool? Checked { get; set; }
        public DateTime? CheckedDate { get; set; }
        public string? LastUpdatedUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
