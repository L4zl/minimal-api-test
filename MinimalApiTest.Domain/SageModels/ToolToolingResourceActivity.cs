using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ToolToolingResourceActivity
    {
        public long ToolToolingResourceActivityId { get; set; }
        public long ToolToolingResourceId { get; set; }
        public long ToolToolingResourceActivityTypeId { get; set; }
        public string? Reference { get; set; }
        public DateTime ThisActivityDate { get; set; }
        public DateTime? NextActivityDate { get; set; }
        public bool Archived { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public string Result { get; set; } = null!;
        public string Notes { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual ToolToolingResource ToolToolingResource { get; set; } = null!;
        public virtual ToolToolingResourceActivityType ToolToolingResourceActivityType { get; set; } = null!;
    }
}
