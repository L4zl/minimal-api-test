using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysprogressDatum
    {
        public long SysprogressDataId { get; set; }
        public long CurrentStatus { get; set; }
        public int Maximum { get; set; }
        public int Value { get; set; }
        public string Description { get; set; } = null!;
        public long Type { get; set; }
        public string? ReturnId { get; set; }
        public byte[]? BinaryException { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeProgressUpdated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
