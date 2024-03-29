﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmpersonStatus
    {
        public long SiconCrmpersonStatusId { get; set; }
        public short PersonStatusNumber { get; set; }
        public string PersonStatusDescription { get; set; } = null!;
        public bool IsSystem { get; set; }
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
