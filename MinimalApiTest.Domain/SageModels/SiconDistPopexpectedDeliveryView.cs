using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistPopexpectedDeliveryView
    {
        public long PoporderReturnLineId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public string ItemCode { get; set; } = null!;
        public string SupplierAccountName { get; set; } = null!;
        public decimal LineQuantity { get; set; }
        public decimal ReceiptReturnQuantity { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public decimal? RemainingQuantity { get; set; }
    }
}
