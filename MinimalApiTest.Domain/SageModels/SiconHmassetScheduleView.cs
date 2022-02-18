using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmassetScheduleView
    {
        public long? BorderObjectId { get; set; }
        public string? ICalGuid { get; set; }
        public bool? ICalInvitationSent { get; set; }
        public int? Type { get; set; }
        public string? Subject { get; set; }
        public int? Status { get; set; }
        public DateTime? StartDate { get; set; }
        public string? ResourceIds { get; set; }
        public int? ICalSequence { get; set; }
        public int? Label { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
        public long SiconAppointmentId { get; set; }
        public bool? AllDay { get; set; }
        public string? Location { get; set; }
        public bool UndefinedHirePeriod { get; set; }
        public bool IsFoc { get; set; }
        public long SiconHmassetConditionId { get; set; }
    }
}
