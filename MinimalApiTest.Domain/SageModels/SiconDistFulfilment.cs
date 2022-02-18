using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistFulfilment
    {
        public long SiconDistSoplineFulfilmentId { get; set; }
        public string? SodocumentNo { get; set; }
        public DateTime? SorequestedDate { get; set; }
        public string? CustomerAccountName { get; set; }
        public string? ItemCode { get; set; }
        public string? WarehouseName { get; set; }
        public string? Fulfilment { get; set; }
        public string? PodocumentNo { get; set; }
        public DateTime? PorequestedDate { get; set; }
        public string? SupplierAccountName { get; set; }
        public decimal SolineQty { get; set; }
        public decimal PolineQty { get; set; }
        public long? RowNumber { get; set; }
    }
}
