using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankFeedPostingInstruction
    {
        public long CbbankFeedPostingInstructionId { get; set; }
        public long CbbankFeedAccountPostingId { get; set; }
        public string Reference { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual CbbankFeedAccountPosting CbbankFeedAccountPosting { get; set; } = null!;
    }
}
