using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmcurrentFalocationView
    {
        public string? HireOrderNumber { get; set; }
        public string CustomerAccountName { get; set; } = null!;
        public DateTime? CollectionDate { get; set; }
        public long SubCategoryId { get; set; }
        public decimal? OnHire { get; set; }
        public decimal? OffHire { get; set; }
        public decimal? InspectionRequired { get; set; }
        public decimal? PassedInspection { get; set; }
        public decimal? FailedInspection { get; set; }
        public decimal? WaitingGoodsReceived { get; set; }
        public long? WarehouseId { get; set; }
    }
}
