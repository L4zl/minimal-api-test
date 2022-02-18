using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TstimeRecord
    {
        public long TstimeRecordId { get; set; }
        public long TspersonId { get; set; }
        public long? TscostRateId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateRecorded { get; set; }
        public long? TspayRateId { get; set; }
        public long? TschargeRateId { get; set; }
        public long Period { get; set; }
        public long TstimesheetPostStatusId { get; set; }
        public long RecordNumber { get; set; }
        public string Narrative { get; set; } = null!;
        public long TstimesheetRecordStatusTypeId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? ParentProjectId { get; set; }
        public long? PcprojectEntryId { get; set; }
        public long Urn { get; set; }
        public string User { get; set; } = null!;
        public long? SourceEntryId { get; set; }
        public int? UserNumber { get; set; }
        public string? NominalAccountNumber { get; set; }
        public string? CostCentre { get; set; }
        public string? Department { get; set; }
        public string RejectReason { get; set; } = null!;
        public bool PostedToPayroll { get; set; }
        public DateTime? PostedToPayrollDate { get; set; }
        public decimal TotalChargeAmount { get; set; }
        public decimal TotalCostAmount { get; set; }
        public decimal TotalPayAmount { get; set; }
        public long? ActivityId { get; set; }
        public string EnteredBy { get; set; } = null!;
        public bool RequiredPostToPayroll { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem? Activity { get; set; }
        public virtual PcprojectItem? ParentProject { get; set; }
        public virtual PcprojectEntry? PcprojectEntry { get; set; }
        public virtual TschargeRate? TschargeRate { get; set; }
        public virtual TscostRate? TscostRate { get; set; }
        public virtual TspayRate? TspayRate { get; set; }
        public virtual Tsperson Tsperson { get; set; } = null!;
        public virtual TstimesheetPostStatus TstimesheetPostStatus { get; set; } = null!;
        public virtual TstimesheetRecordStatusType TstimesheetRecordStatusType { get; set; } = null!;
    }
}
