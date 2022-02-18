using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderAutoReport
    {
        public long SiWorksOrderAutoReportId { get; set; }
        public string? WhenToRun { get; set; }
        public bool? Run { get; set; }
        public string? ReportName { get; set; }
        public string? ReportLocation { get; set; }
    }
}
