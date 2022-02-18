using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysdesktopListFilter
    {
        public long SysdesktopListFilterId { get; set; }
        public string DesktopList { get; set; } = null!;
        public string FilterName { get; set; } = null!;
        public long? UserId { get; set; }
        public string SerializedFilter { get; set; } = null!;
    }
}
