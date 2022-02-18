using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmhistory
    {
        public long SiSmhistoryId { get; set; }
        public long SiSmcaseId { get; set; }
        public DateTime? DateTime { get; set; }
        public string? SageUser { get; set; }
        public string? Details { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
