using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEcncaseSignOff
    {
        public long SiconEcncaseSignOffId { get; set; }
        public long SiconEcnsignOffId { get; set; }
        public long SiconEcrcaseId { get; set; }
        public bool? Complete { get; set; }
        public string? CompletedBy { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
