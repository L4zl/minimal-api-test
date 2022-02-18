using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFastatus
    {
        public long FastatusId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool Editable { get; set; }
    }
}
