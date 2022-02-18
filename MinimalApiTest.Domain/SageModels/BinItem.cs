using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BinItem
    {
        public BinItem()
        {
            AllocationBalances = new HashSet<AllocationBalance>();
            MovementBalances = new HashSet<MovementBalance>();
            PoprcptReturnLineArches = new HashSet<PoprcptReturnLineArch>();
            PopreceiptReturnLines = new HashSet<PopreceiptReturnLine>();
            SiWosubContractDespatchLines = new HashSet<SiWosubContractDespatchLine>();
            StocktakeCountSheetItems = new HashSet<StocktakeCountSheetItem>();
            TraceableBinItems = new HashSet<TraceableBinItem>();
        }

        public long BinItemId { get; set; }
        public string BinName { get; set; } = null!;
        public long ItemId { get; set; }
        public long WarehouseItemId { get; set; }
        public DateTime? DateOfLastStockCount { get; set; }
        public decimal LastCostPrice { get; set; }
        public DateTime? OpeningBalanceDate { get; set; }
        public bool UnspecifiedBin { get; set; }
        public decimal ConfirmedQtyInStock { get; set; }
        public decimal UnconfirmedQtyInStock { get; set; }
        public decimal QuantityAllocatedSop { get; set; }
        public decimal QuantityAllocatedStock { get; set; }
        public decimal QuantityAllocatedBom { get; set; }
        public decimal QuantityReserved { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public string SpareText1 { get; set; } = null!;
        public string SpareText2 { get; set; } = null!;
        public string SpareText3 { get; set; } = null!;
        public decimal SpareNumber1 { get; set; }
        public decimal SpareNumber2 { get; set; }
        public decimal SpareNumber3 { get; set; }
        public DateTime? SpareDate1 { get; set; }
        public DateTime? SpareDate2 { get; set; }
        public DateTime? SpareDate3 { get; set; }
        public bool SpareBit1 { get; set; }
        public bool SpareBit2 { get; set; }
        public bool SpareBit3 { get; set; }
        public long AllocationPriority { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual StockItem Item { get; set; } = null!;
        public virtual WarehouseItem WarehouseItem { get; set; } = null!;
        public virtual ICollection<AllocationBalance> AllocationBalances { get; set; }
        public virtual ICollection<MovementBalance> MovementBalances { get; set; }
        public virtual ICollection<PoprcptReturnLineArch> PoprcptReturnLineArches { get; set; }
        public virtual ICollection<PopreceiptReturnLine> PopreceiptReturnLines { get; set; }
        public virtual ICollection<SiWosubContractDespatchLine> SiWosubContractDespatchLines { get; set; }
        public virtual ICollection<StocktakeCountSheetItem> StocktakeCountSheetItems { get; set; }
        public virtual ICollection<TraceableBinItem> TraceableBinItems { get; set; }
    }
}
