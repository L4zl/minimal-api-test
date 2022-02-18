using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcasePartBill
    {
        public long SiSmcasePartBillId { get; set; }
        public long SiSmcaseId { get; set; }
        public long SoporderReturnId { get; set; }
        public bool? RaisedCase { get; set; }
        public bool? LinkedCase { get; set; }
        public long? SoporderReturnLineId { get; set; }
    }
}
