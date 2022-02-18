using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmFeature
    {
        public MsmFeature()
        {
            MsmUserFeatures = new HashSet<MsmUserFeature>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmFeatureId { get; set; }
        /// <summary>
        /// Meaningful form/module name for display purposes
        /// </summary>
        public string Title { get; set; } = null!;
        /// <summary>
        /// Actual forn name
        /// </summary>
        public string? FormName { get; set; }
        public long? ParentFeatureId { get; set; }
        /// <summary>
        /// The ordinal position in which this feature will be displayed.
        /// </summary>
        public decimal? Sequence { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MsmUserFeature> MsmUserFeatures { get; set; }
    }
}
