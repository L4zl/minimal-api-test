using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmappointmentsView
    {
        public int IsComplete { get; set; }
        public int IsCaseAppointment { get; set; }
        public int IsWorkAppointment { get; set; }
        public int IsTravelAppointment { get; set; }
        public int CurrentlyAttending { get; set; }
        public int AllowModification { get; set; }
        public bool IsWorkComplete { get; set; }
        public long SiconAppointmentId { get; set; }
        public long? SiconResourceId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Subject { get; set; }
        public bool? AllDay { get; set; }
        public string? Description { get; set; }
        public int? Label { get; set; }
        public string? Location { get; set; }
        public long? BorderObjectId { get; set; }
        public string? ResourceIds { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public bool? ICalInvitationSent { get; set; }
        public string? ICalGuid { get; set; }
        public int? ICalSequence { get; set; }
        public long? SiSmcaseId { get; set; }
        public bool? Downloaded { get; set; }
        public string? CustomerName { get; set; }
        public string? ToPostcode { get; set; }
        public string? ToAddressCity { get; set; }
        public string? WorkBriefing { get; set; }
        public string? CaseSummary { get; set; }
        public string? CaseLocationDesc { get; set; }
    }
}
