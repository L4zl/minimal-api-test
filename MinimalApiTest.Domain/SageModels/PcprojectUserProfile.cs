using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectUserProfile
    {
        public long PcprojectUserProfileId { get; set; }
        public long TspersonId { get; set; }
        public bool FilterProjects { get; set; }

        public virtual Tsperson Tsperson { get; set; } = null!;
    }
}
