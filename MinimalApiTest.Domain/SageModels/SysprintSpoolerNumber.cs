using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysprintSpoolerNumber
    {
        public long SysprintSpoolerNumberId { get; set; }
        public long NextPrintSpoolerNumber { get; set; }
    }
}
