using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmserviceDeskUserFilter
    {
        public long SiSmserviceDeskUserFilterId { get; set; }
        public long? UserId { get; set; }
        public long? CustomerId { get; set; }
        public long? ContactId { get; set; }
        public long? LocationId { get; set; }
        public string? CaseReference { get; set; }
        public string? Summary { get; set; }
        public long? ItemId { get; set; }
        public string? SerialNo { get; set; }
        public string? SerialId { get; set; }
        public string? CaseTypes { get; set; }
        public long? CoverTypeId { get; set; }
        public string? CaseStatuss { get; set; }
        public long? SubStatusId { get; set; }
        public string? TrackingStatuss { get; set; }
        public long? FaultCodeId { get; set; }
        public int? SortIndex { get; set; }
        public string? SortDirection { get; set; }
    }
}
