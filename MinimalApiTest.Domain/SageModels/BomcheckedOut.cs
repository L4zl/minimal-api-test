using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class BomcheckedOut
    {
        public BomcheckedOut()
        {
            BomlineCheckedOuts = new HashSet<BomlineCheckedOut>();
            Boms = new HashSet<Bom>();
        }

        public long BomcheckedOutId { get; set; }
        public DateTime? CheckedOutOn { get; set; }
        public string? CheckedOutByUserName { get; set; }
        public long Bomid { get; set; }
        public long StockItemId { get; set; }
        public string? Bomversion { get; set; }
        public string? BomshortName { get; set; }
        public string? ChangeReference { get; set; }
        public bool IsOnHold { get; set; }
        public long? BomreasonForHoldId { get; set; }
        public DateTime? HoldDate { get; set; }
        public long BomstatusId { get; set; }
        public bool IsCostDirty { get; set; }
        public bool AutoOverheadComputation { get; set; }
        public decimal OverheadCost { get; set; }
        public decimal PerUnitMaterialCost { get; set; }
        public decimal PerUnitExpenseCost { get; set; }
        public decimal AverageRunSizeForBatch { get; set; }
        public decimal PerBatchExpenseCost { get; set; }
        public decimal TotalCost { get; set; }
        public string? CreatedByUserName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? LastAmendedByUserName { get; set; }
        public DateTime? LastamendedOn { get; set; }
        public bool HasComponentReferences { get; set; }
        public DateTime? CheckedOutTime { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual Old200BomreasonForHold? BomreasonForHold { get; set; }
        public virtual BomstatusType Bomstatus { get; set; } = null!;
        public virtual ICollection<BomlineCheckedOut> BomlineCheckedOuts { get; set; }
        public virtual ICollection<Bom> Boms { get; set; }
    }
}
