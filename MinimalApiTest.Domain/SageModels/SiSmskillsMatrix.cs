using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmskillsMatrix
    {
        public long SiSmskillsMatrixId { get; set; }
        public long? SiJcEmpId { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public long? SiSmskillId { get; set; }
        public string? SkillName { get; set; }
        public long? AbilityId { get; set; }
        public string? AbilityName { get; set; }
    }
}
