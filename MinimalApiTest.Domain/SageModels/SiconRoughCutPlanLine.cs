using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRoughCutPlanLine
    {
        public long SiconRoughCutPlanLineId { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public DateTime? WeekEndDate { get; set; }
        public long? DeptId { get; set; }
        public string? DeptCode { get; set; }
        public string? DeptDescription { get; set; }
        public decimal? Available { get; set; }
        public decimal? Required { get; set; }
        public long? BomcostTypeId { get; set; }
        public string? Wonumber { get; set; }
    }
}
