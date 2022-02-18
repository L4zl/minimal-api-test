using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmattributeList
    {
        public long SiconTcmattributeListId { get; set; }
        public string ListName { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
