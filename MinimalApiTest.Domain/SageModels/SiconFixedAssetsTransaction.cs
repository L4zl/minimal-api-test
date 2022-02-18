using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFixedAssetsTransaction
    {
        public long Transactionid { get; set; }
        public long? UniqueReferenceNumber { get; set; }
        public string? GroupId { get; set; }
        public long FixedAssetId { get; set; }
        public DateTime? DateTimePosted { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public string? ChangedTo { get; set; }
        public long? TypeId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiJcChdId { get; set; }
        public string? ChangedFrom { get; set; }
        public string? UpdatedUser { get; set; }
    }
}
