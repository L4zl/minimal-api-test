using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorderType
    {
        public long SiconHmorderTypeId { get; set; }
        public string? Name { get; set; }
        public bool? ReferenceEnabled { get; set; }
        public string? Reference { get; set; }
        public bool? CostCentreEnabled { get; set; }
        public string? CostCentre { get; set; }
        public bool? DeptEnabled { get; set; }
        public string? Dept { get; set; }
        public long? CustomerId { get; set; }
        public string? HtmlColourCodeForApptLabel { get; set; }
    }
}
