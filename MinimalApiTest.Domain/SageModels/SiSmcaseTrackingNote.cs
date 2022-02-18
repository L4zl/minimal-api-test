using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcaseTrackingNote
    {
        public long SiSmcaseTrackingNoteId { get; set; }
        public long? SiSmcaseId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? Description { get; set; }
        public string? CreatedBy { get; set; }
        public long? StatusId { get; set; }
        public bool? Deleted { get; set; }
        public long? ReassignedTo { get; set; }
        public long? ReassignedToSiJcRoleId { get; set; }
        public bool? VisibleToEngineers { get; set; }
        public long? SiSmcaseAdditionalLabourId { get; set; }
        public bool? VisibleToCustomer { get; set; }
        public bool? UnviewedInSage { get; set; }
        public long? SiconAppointmentId { get; set; }
        public decimal? HoursSpent { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public long? ReassignedToExternalTeamId { get; set; }
    }
}
