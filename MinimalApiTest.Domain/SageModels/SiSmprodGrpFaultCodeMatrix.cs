using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmprodGrpFaultCodeMatrix
    {
        public long SiSmprodGrpFaultCodeMatrixId { get; set; }
        public long? ProductGroupId { get; set; }
        public long? SiSmskillId { get; set; }
        public long? SiSmfaultCodeId { get; set; }
        public bool? Selected { get; set; }
    }
}
