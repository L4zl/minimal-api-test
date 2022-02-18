using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPotrackingType
    {
        public long SiconDistPotrackingTypeId { get; set; }
        public long SiconDistPotrackingProfile { get; set; }
        public long? Number { get; set; }
        public string? Description { get; set; }
        public long? Days { get; set; }
        public bool? WorkingDays { get; set; }
        public bool Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? SiconDistPoporderLineStatusId { get; set; }
    }
}
