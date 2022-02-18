using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoprepeatOrderSchedule
    {
        public long SoprepeatOrderScheduleId { get; set; }
        public string Description { get; set; } = null!;
        public long? SoprepeatOrderTypeId { get; set; }
        public short FrequencyValue { get; set; }
        public long? FrequencyTimeUnitId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short DayOfMonth { get; set; }
        public short TotalRepeatCount { get; set; }
        public short CurrentRepeatCount { get; set; }
        public DateTime? LastGeneratedDate { get; set; }
        public long SoporderTemplateId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual TimeUnit? FrequencyTimeUnit { get; set; }
        public virtual SoporderReturn SoporderTemplate { get; set; } = null!;
        public virtual SoprepeatOrderType? SoprepeatOrderType { get; set; }
    }
}
