using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcentryPostingStatus
    {
        public PcentryPostingStatus()
        {
            PcprojectEntryPostings = new HashSet<PcprojectEntryPosting>();
        }

        public long PcentryPostingStatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcprojectEntryPosting> PcprojectEntryPostings { get; set; }
    }
}
