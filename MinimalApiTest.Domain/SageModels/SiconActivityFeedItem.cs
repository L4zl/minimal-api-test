using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconActivityFeedItem
    {
        public long SiconActivityFeedItemId { get; set; }
        public long SiconActivityFeedItemTypeId { get; set; }
        public string? ActivityKey { get; set; }
        public long? ActivityKeyForeignId { get; set; }
        public DateTime ActivityDate { get; set; }
        public string ActivityUser { get; set; } = null!;
        public string ActivityDescription { get; set; } = null!;
        public long? ActivityEmployeeId { get; set; }
        public string? AttachmentModulePath { get; set; }
        public string? AttachmentItemPath { get; set; }
        public string? AttachmentFileName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; } = null!;
    }
}
