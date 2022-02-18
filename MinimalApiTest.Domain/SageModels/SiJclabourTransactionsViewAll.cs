using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJclabourTransactionsViewAll
    {
        public long? Sijcjobid { get; set; }
        public long? Sijcchdid { get; set; }
        public decimal? Commitquantity { get; set; }
        public decimal? Actualquantity { get; set; }
        public int SiJcvariationId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SijobStageId { get; set; }
        public long? SijobSubStageId { get; set; }
    }
}
