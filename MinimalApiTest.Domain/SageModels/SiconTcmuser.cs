using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTcmuser
    {
        public long SiconTcmuserId { get; set; }
        public int? SageLinkedUserId { get; set; }
        public string LogonName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public bool Enabled { get; set; }
        public string? PasswordHash { get; set; }
        public bool? CanViewAllTasks { get; set; }
    }
}
