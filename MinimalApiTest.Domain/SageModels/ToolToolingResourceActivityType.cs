﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ToolToolingResourceActivityType
    {
        public ToolToolingResourceActivityType()
        {
            ToolToolingResourceActivities = new HashSet<ToolToolingResourceActivity>();
        }

        public long ToolToolingResourceActivityTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<ToolToolingResourceActivity> ToolToolingResourceActivities { get; set; }
    }
}
