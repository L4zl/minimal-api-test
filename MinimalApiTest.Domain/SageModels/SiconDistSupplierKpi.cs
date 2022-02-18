using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSupplierKpi
    {
        public long SiconDistSupplierKpiid { get; set; }
        public long? SupplierId { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public long? PopreceiptReturnLineId { get; set; }
        public decimal ReceiptReturnQuantity { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string Kpiperformance { get; set; } = null!;
        public long? SiconDistSupplierKpibandId { get; set; }
        public long? ItemId { get; set; }
    }
}
