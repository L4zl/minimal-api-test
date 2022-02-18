﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsPaymentLineStatus
    {
        public long SiconDdsPaymentLineStatusId { get; set; }
        public string Name { get; set; } = null!;
        public string FriendlyName { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
