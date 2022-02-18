using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Stocktake
    {
        public Stocktake()
        {
            StocktakeCountSheetItems = new HashSet<StocktakeCountSheetItem>();
            StocktakeItems = new HashSet<StocktakeItem>();
            StocktakeLiveBinItems = new HashSet<StocktakeLiveBinItem>();
        }

        public long StocktakeId { get; set; }
        public long WarehouseId { get; set; }
        public long StocktakeSelectorId { get; set; }
        public long StockVarianceNomCodeId { get; set; }
        public DateTime? StocktakeDate { get; set; }
        public DateTime? CountingDate { get; set; }
        public string NominalNarrative { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public bool ShowExpectedQuantity { get; set; }
        public long StocktakeStatusId { get; set; }
        public long StocktakeTypeId { get; set; }
        public string StocktakeName { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }
        public bool ExcludeInactiveStock { get; set; }

        public virtual NlnominalAccount StockVarianceNomCode { get; set; } = null!;
        public virtual StocktakeSelector StocktakeSelector { get; set; } = null!;
        public virtual StocktakeStatus StocktakeStatus { get; set; } = null!;
        public virtual StocktakeType StocktakeType { get; set; } = null!;
        public virtual Warehouse Warehouse { get; set; } = null!;
        public virtual ICollection<StocktakeCountSheetItem> StocktakeCountSheetItems { get; set; }
        public virtual ICollection<StocktakeItem> StocktakeItems { get; set; }
        public virtual ICollection<StocktakeLiveBinItem> StocktakeLiveBinItems { get; set; }
    }
}
