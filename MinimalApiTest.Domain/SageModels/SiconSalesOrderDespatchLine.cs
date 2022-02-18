using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSalesOrderDespatchLine
    {
        public long SiconSalesOrderDespatchLineId { get; set; }
        public long? SiconSalesOrderLineId { get; set; }
        public long? TransactionHistoryId { get; set; }
        public string? DeliveryNoteNumber { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Allocated { get; set; }
        public decimal? Despatched { get; set; }
        public decimal? DespatchedThisTime { get; set; }
        public decimal? AppliedQuantity { get; set; }
        public decimal? UnitValue { get; set; }
    }
}
