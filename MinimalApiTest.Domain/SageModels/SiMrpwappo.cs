using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiMrpwappo
    {
        public long SiMrpwappoid { get; set; }
        public long? WaporderId { get; set; }
        public string? Wapstatus { get; set; }
        public string? WapreqNumber { get; set; }
        public string? Ponumber { get; set; }
        public DateTime? DocumentDate { get; set; }
        public long? SupplierId { get; set; }
        public string? SupplierReference { get; set; }
        public string? SupplierName { get; set; }
        public bool? Deleted { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public bool? Processed { get; set; }
        public long? SopdocDelAddressId { get; set; }
        public long? FulfilmentType { get; set; }
    }
}
