using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomReasonForHold
    {
        public BomReasonForHold()
        {
            BomRecords = new HashSet<BomRecord>();
        }

        public long BomReasonForHoldId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool FixedReason { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<BomRecord> BomRecords { get; set; }
    }
}
