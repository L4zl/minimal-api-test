using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseSlastage
    {
        public long SiSmcaseSlastageId { get; set; }
        public long SiSmcaseId { get; set; }
        public long? SiSmslatriggerId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsPaused { get; set; }
        public DateTime? PauseTime { get; set; }
        public bool? IsComplete { get; set; }
        public DateTime? CompletedTime { get; set; }
        public DateTime? WarningTime { get; set; }
        public decimal? PauseTimeRemainingHours { get; set; }
        public decimal? CompletedTimeRemainingHours { get; set; }
        public string? ReminderDescription { get; set; }
    }
}
