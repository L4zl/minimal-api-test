using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmskillsMatrixView
    {
        public long? PrimaryKey { get; set; }
        public long Sijcempid { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public long SiSmskillId { get; set; }
        public string? Name { get; set; }
    }
}
