using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmexpensePolink
    {
        public long SiSmexpensePolinkId { get; set; }
        public long SiSmcaseId { get; set; }
        public long PoporderReturnId { get; set; }
        public long? SiconEmployeeId { get; set; }
        public decimal? RequiredMargin { get; set; }
    }
}
