using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderForecastLine
    {
        public long SiWorksOrderForecastLineId { get; set; }
        public long? CustomerId { get; set; }
        public long? ItemId { get; set; }
        public long? ComponentWarehouseId { get; set; }
        public long? FinishedWarehouseId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Quantity { get; set; }
        public string? ForecastNo { get; set; }
        public string? SopdocumentNo { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public string? Comments { get; set; }
    }
}
