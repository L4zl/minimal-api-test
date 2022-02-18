using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcconstructionTotal
    {
        public long Sijcjobid { get; set; }
        public decimal ApplicationsToDate { get; set; }
        public decimal ApplicationsNetToDate { get; set; }
        public decimal ApplicationsDiscount { get; set; }
        public decimal Applications { get; set; }
        public decimal Valuations { get; set; }
        public decimal Retentions { get; set; }
        public decimal Invoiced { get; set; }
    }
}
