using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderDept
    {
        public long SiWorksOrderDeptId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? DefaultStartArea { get; set; }
    }
}
