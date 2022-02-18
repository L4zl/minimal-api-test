using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconEmailMessage
    {
        public long SiconEmailMessageId { get; set; }
        public long? SiconEmailTemplateId { get; set; }
        public long? DataSourceId { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public string? To { get; set; }
        public string? Cc { get; set; }
        public string? Bcc { get; set; }
        public string? SentBy { get; set; }
        public DateTime? TimeSent { get; set; }
        public long? ProductId { get; set; }
        public long? ProductAreaId { get; set; }
        public long? DataType { get; set; }
        public string? MsgPath { get; set; }
    }
}
