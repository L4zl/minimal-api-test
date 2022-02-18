using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsCustomersRequiringInstructionsView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string CustomerAccountShortName { get; set; } = null!;
        public string CustomerAccountName { get; set; } = null!;
    }
}
