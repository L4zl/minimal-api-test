using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class WopBuild
    {
        public WopBuild()
        {
            WopBuildComponents = new HashSet<WopBuildComponent>();
            WopBuildProducts = new HashSet<WopBuildProduct>();
        }

        public long WopBuildId { get; set; }
        public long WopOrderId { get; set; }
        public long? BomBuildSessionId { get; set; }
        public DateTime BuildDateTime { get; set; }
        public string BuiltBy { get; set; } = null!;
        public string BuildReference { get; set; } = null!;
        public string BuildNumber { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool TopLevel { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomBuildSession? BomBuildSession { get; set; }
        public virtual WopOrder WopOrder { get; set; } = null!;
        public virtual ICollection<WopBuildComponent> WopBuildComponents { get; set; }
        public virtual ICollection<WopBuildProduct> WopBuildProducts { get; set; }
    }
}
