using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomHistory
    {
        public long BomHistoryId { get; set; }
        public long BomRecordId { get; set; }
        public string StockCode { get; set; } = null!;
        public string BomReference { get; set; } = null!;
        public string BomDescription { get; set; } = null!;
        public string BomVersion { get; set; } = null!;
        public DateTime CreationDateTime { get; set; }
        public string CreatedByUser { get; set; } = null!;
        public long BomHistoryTypeId { get; set; }
        public string Reference { get; set; } = null!;
        public string Comment { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public string? BomFamilyIdentifier { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomHistoryType BomHistoryType { get; set; } = null!;
    }
}
