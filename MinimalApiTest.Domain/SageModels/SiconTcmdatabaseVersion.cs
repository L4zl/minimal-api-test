﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmdatabaseVersion
    {
        public long SiconTcmdatabaseVersionId { get; set; }
        public int DatabaseVersion { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
