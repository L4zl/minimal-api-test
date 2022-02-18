using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsactivityGroupsVw
    {
        public string? Code { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public long? PcprojectItemId { get; set; }
        public long PcintegrationOptionId { get; set; }
    }
}
