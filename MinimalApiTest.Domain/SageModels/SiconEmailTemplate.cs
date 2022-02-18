using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEmailTemplate
    {
        public long SiconEmailTemplateId { get; set; }
        public string? Name { get; set; }
        public long? ProductId { get; set; }
        public long? ProductAreaId { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public bool? Deleted { get; set; }
        public string? To { get; set; }
        public string? Cc { get; set; }
        public string? Bcc { get; set; }
        public long? DataType { get; set; }
    }
}
