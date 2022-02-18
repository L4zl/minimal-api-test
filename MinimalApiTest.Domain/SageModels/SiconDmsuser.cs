using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsuser
    {
        public long SiconDmsuserId { get; set; }
        public long? SageUserId { get; set; }
        public bool IndexDocuments { get; set; }
        public bool DeleteDocuments { get; set; }
        public string DefaultAttachmentPath { get; set; } = null!;
        public bool DeleteOnIndexing { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public short ViewRights { get; set; }
        public string SageUserName { get; set; } = null!;
        public short DefaultIndexOption { get; set; }
        public bool? ReIndexDocuments { get; set; }
        public bool OutlookIntegration { get; set; }
    }
}
