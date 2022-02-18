using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFareport
    {
        public long RowId { get; set; }
        public string? Column1 { get; set; }
        public decimal? Column2 { get; set; }
        public decimal? Column3 { get; set; }
        public decimal? Column4 { get; set; }
    }
}
