using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MigrationMessage
    {
        public long MigrationMessageId { get; set; }
        public string Message { get; set; } = null!;
        public string Data { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
