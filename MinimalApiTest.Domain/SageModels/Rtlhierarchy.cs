using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Rtlhierarchy
    {
        public long HierNodeId { get; set; }
        public string HierNodeName { get; set; } = null!;
        public long? ParentHierNodeId { get; set; }
        public long? LevelSeq { get; set; }
        public long? StoreId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string? Description { get; set; }
        public string? NodesGuid { get; set; }
        public string? PostalName { get; set; }
        public string? PostCode { get; set; }
        public string? ContactName { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public long? CountryCode { get; set; }
        public bool? DummyEntry { get; set; }
        public string? Address5 { get; set; }
        public string? Address6 { get; set; }
        public string? Country { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
