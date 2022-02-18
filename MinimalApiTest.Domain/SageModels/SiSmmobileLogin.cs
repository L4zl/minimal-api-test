using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmmobileLogin
    {
        public long SiSmmobileLoginId { get; set; }
        public long SiJcEmpId { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public bool? Enabled { get; set; }
    }
}
