using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderSequence
    {
        public long SiWorksOrderSequenceId { get; set; }
        public long SequenceNumber { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? SiWorksOrderDeptId { get; set; }
        public int? DueListId { get; set; }
    }
}
