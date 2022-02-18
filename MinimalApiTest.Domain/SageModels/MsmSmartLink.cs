using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmSmartLink
    {
        public long MsmSmartLinkId { get; set; }
        public string FormName { get; set; } = null!;
    }
}
