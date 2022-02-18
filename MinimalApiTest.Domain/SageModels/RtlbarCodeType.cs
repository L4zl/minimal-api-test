using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class RtlbarCodeType
    {
        public long BarCodeTypeId { get; set; }
        public string BarCodeName { get; set; } = null!;
    }
}
