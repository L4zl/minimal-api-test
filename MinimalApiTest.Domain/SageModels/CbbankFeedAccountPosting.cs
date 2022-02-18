using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbbankFeedAccountPosting
    {
        public CbbankFeedAccountPosting()
        {
            CbbankFeedPostingInstructions = new HashSet<CbbankFeedPostingInstruction>();
        }

        public long CbbankFeedAccountPostingId { get; set; }
        public long CbbankFeedTransactionId { get; set; }
        public string AccountantNarrative { get; set; } = null!;
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public decimal TaxAmount { get; set; }

        public virtual CbbankFeedTransaction CbbankFeedTransaction { get; set; } = null!;
        public virtual ICollection<CbbankFeedPostingInstruction> CbbankFeedPostingInstructions { get; set; }
    }
}
