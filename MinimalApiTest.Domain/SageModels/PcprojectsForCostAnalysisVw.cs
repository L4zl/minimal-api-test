﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectsForCostAnalysisVw
    {
        public long PcprojectItemId { get; set; }
        public string Code { get; set; } = null!;
        public long PcintegrationOptionId { get; set; }
    }
}