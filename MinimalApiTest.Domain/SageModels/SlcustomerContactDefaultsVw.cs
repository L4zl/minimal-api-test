﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerContactDefaultsVw
    {
        public long SlcustomerAccountId { get; set; }
        public long SlcustomerContactId { get; set; }
        public string Contact { get; set; } = null!;
        public bool? IsDefaultRole { get; set; }
        public string? DefaultTelephone { get; set; }
        public string? DefaultFax { get; set; }
        public string? DefaultEmail { get; set; }
        public string? DefaultWebsite { get; set; }
        public string? DefaultMobile { get; set; }
        public bool? IsPreferredContactForRole { get; set; }
        public string? ContactRoleName { get; set; }
    }
}