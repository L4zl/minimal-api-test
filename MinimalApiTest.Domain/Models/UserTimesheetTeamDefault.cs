﻿namespace MinimalApiTest.Domain.Models
{
    public partial class UserTimesheetTeamDefault
    {
        public long UserTimesheetTeamDefaultId { get; set; }
        public long? UserId { get; set; }
        public long? LinkedUserId { get; set; }
        public bool? Monday { get; set; }
        public bool? Tuesday { get; set; }
        public bool? Wednesday { get; set; }
        public bool? Thursday { get; set; }
        public bool? Friday { get; set; }
        public bool? Saturday { get; set; }
        public bool? Sunday { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
