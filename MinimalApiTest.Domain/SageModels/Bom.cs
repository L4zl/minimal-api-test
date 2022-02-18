using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Bom
    {
        public Bom()
        {
            BomallocFinishedItems = new HashSet<BomallocFinishedItem>();
            BombuildFinishedItems = new HashSet<BombuildFinishedItem>();
            Bomlines = new HashSet<Bomline>();
        }

        public long Bomid { get; set; }
        public long StockItemId { get; set; }
        public string Bomversion { get; set; } = null!;
        public string BomshortName { get; set; } = null!;
        public string? ChangeReference { get; set; }
        public bool IsOnHold { get; set; }
        public long? BomreasonForHoldId { get; set; }
        public DateTime? HoldDate { get; set; }
        public long BomstatusId { get; set; }
        public bool IsCostDirty { get; set; }
        public bool IsCheckedOut { get; set; }
        public long? BomcheckedOutId { get; set; }
        public bool? AutoOverheadComputation { get; set; }
        public decimal OverheadCost { get; set; }
        public decimal PerUnitMaterialCost { get; set; }
        public decimal PerUnitExpenseCost { get; set; }
        public decimal AverageRunSizeForBatch { get; set; }
        public decimal PerBatchExpenseCost { get; set; }
        public decimal TotalCost { get; set; }
        public string CreatedByUserName { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public string LastAmendedByUserName { get; set; } = null!;
        public DateTime LastAmendedOn { get; set; }
        public bool HasComponentReferences { get; set; }
        public DateTime LastAmendedTime { get; set; }
        public bool IsCurrentlyActive { get; set; }
        public bool IsMostRecent { get; set; }
        public string Code { get; set; } = null!;
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
        public DateTime DateTimeUpdated { get; set; }

        public virtual BomcheckedOut? BomcheckedOut { get; set; }
        public virtual Old200BomreasonForHold? BomreasonForHold { get; set; }
        public virtual BomstatusType Bomstatus { get; set; } = null!;
        public virtual ICollection<BomallocFinishedItem> BomallocFinishedItems { get; set; }
        public virtual ICollection<BombuildFinishedItem> BombuildFinishedItems { get; set; }
        public virtual ICollection<Bomline> Bomlines { get; set; }
    }
}
