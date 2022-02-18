using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmcurrentCrossHiresView
    {
        public string? HireOrderNumber { get; set; }
        public string? CustomerAccountName { get; set; }
        public DateTime? CollectionDate { get; set; }
        public long? SubCategoryId { get; set; }
        public string? SupplierAccountName { get; set; }
        public string? PopdocumentNo { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public int? WaitingGoodsReceived { get; set; }
        public int? ReturnedToSupplier { get; set; }
    }
}
