using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class GdprcontactCheckView
    {
        public long PrimaryKey { get; set; }
        public long? ParentId { get; set; }
        public string SysmoduleName { get; set; } = null!;
        public string EntityType { get; set; } = null!;
        public string EntityFirstTitle { get; set; } = null!;
        public string? EntityFirstValue { get; set; }
        public string? EntitySecondTitle { get; set; }
        public string? EntitySecondValue { get; set; }
        public string? EntityContactTitle { get; set; }
        public string? ContactName { get; set; }
    }
}
