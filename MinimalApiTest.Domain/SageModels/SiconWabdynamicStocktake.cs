using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabdynamicStocktake
    {
        public long SiconWabdynamicStocktakeId { get; set; }
        public string Description { get; set; } = null!;
        public long StockTakeStatusId { get; set; }
        public long WarehouseId { get; set; }
        public DateTime? DateTimeCreated { get; set; }
    }
}
