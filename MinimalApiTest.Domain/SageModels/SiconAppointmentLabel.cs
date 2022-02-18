using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAppointmentLabel
    {
        public long SiconAppointmentLabelId { get; set; }
        public string? HtmlColourCode { get; set; }
        public string? Caption { get; set; }
    }
}
