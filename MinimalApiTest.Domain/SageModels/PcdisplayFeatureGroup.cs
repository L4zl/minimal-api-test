using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcdisplayFeatureGroup
    {
        public PcdisplayFeatureGroup()
        {
            PcdisplayFeatures = new HashSet<PcdisplayFeature>();
        }

        public long PcdisplayFeatureGroupId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PcdisplayFeature> PcdisplayFeatures { get; set; }
    }
}
