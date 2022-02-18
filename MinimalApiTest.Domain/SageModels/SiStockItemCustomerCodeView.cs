using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiStockItemCustomerCodeView
    {
        public string CustomerAccountNumber { get; set; } = null!;
        public string? CustomerBarcode { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescription { get; set; }
        public long ItemId { get; set; }
        public long SiStockItemCustomerCodeId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public long SoporderReturnLineId { get; set; }
    }
}
