using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmUserFeature
    {
        public long MsmUserFeatureId { get; set; }
        /// <summary>
        /// MsmUser table primary key
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// MsmFeature table primary key
        /// </summary>
        public long FeatureId { get; set; }
        /// <summary>
        /// Optimistic locking setting for tables that are updated by ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Creation date/time
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MsmFeature Feature { get; set; } = null!;
        public virtual MsmUser User { get; set; } = null!;
    }
}
