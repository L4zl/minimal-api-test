using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderHasSubAssemblyView
    {
        public int HasSubAssembly { get; set; }
        public int HasParent { get; set; }
        public long SiWorksOrderId { get; set; }
    }
}
