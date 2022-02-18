using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEmployeePostCodeArea
    {
        public long SiJcEmpPostCodeAreaId { get; set; }
        public long SiJcEmpId { get; set; }
        public string PostCodeArea { get; set; } = null!;
    }
}
