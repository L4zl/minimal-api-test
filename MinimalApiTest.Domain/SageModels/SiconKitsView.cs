using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconKitsView
    {
        public string Reference { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public string? SodocumentNo { get; set; }
        public string? CustomerName { get; set; }
        public string? Status { get; set; }
    }
}
