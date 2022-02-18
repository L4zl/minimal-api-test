using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TsclaimRecord
    {
        public long TsclaimRecordId { get; set; }
        public long? ParentProjectId { get; set; }
        public decimal Quantity { get; set; }
        public long? AuthoriseBehaviourId { get; set; }
        public long? RejectBehaviourId { get; set; }
        public long? TscategoryGroupId { get; set; }
        public long TsclaimSheetId { get; set; }
        public DateTime DateIncurred { get; set; }
        public DateTime DateEntered { get; set; }
        public string Description { get; set; } = null!;
        public long TsreceiptAttachedTypeId { get; set; }
        public long TsclaimRecordStatusId { get; set; }
        public long SystaxCodeId { get; set; }
        public long? TscategoryId { get; set; }
        public decimal UnitRate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public decimal TaxAmount { get; set; }
        public long? PcprojectEntryId { get; set; }
        public decimal OverheadUpliftRate { get; set; }
        public bool PostedToPayroll { get; set; }
        public DateTime? PostedToPayrollDate { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public long? ActivityId { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem? Activity { get; set; }
        public virtual PcprojectItem? ParentProject { get; set; }
        public virtual PcprojectEntry? PcprojectEntry { get; set; }
        public virtual TscategoryComponent? Tscategory { get; set; }
        public virtual TscategoryComponent? TscategoryGroup { get; set; }
        public virtual TsclaimRecordStatusType TsclaimRecordStatus { get; set; } = null!;
        public virtual TsclaimSheet TsclaimSheet { get; set; } = null!;
        public virtual TsreceiptAttachedType TsreceiptAttachedType { get; set; } = null!;
    }
}
