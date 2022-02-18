using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmcustReturn
    {
        public long SiSmcustReturnId { get; set; }
        public long SiSmcaseId { get; set; }
        public int ReturnSourceType { get; set; }
        public long? ItemId { get; set; }
        public long? SiconEquipmentId { get; set; }
        public string? Ftdescription { get; set; }
        public string? Notes { get; set; }
        public bool? IsAdvanceReturn { get; set; }
        public bool? ReturnRecordCreated { get; set; }
        public int PartStatus { get; set; }
        public bool? CreditRequested { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public DateTime? ActualReceiptDate { get; set; }
        public decimal? Quantity { get; set; }
        public int ProcessingStatus { get; set; }
        public int? PartQualityStatusId { get; set; }
        public long? SiSmreturnSubStatusId { get; set; }
        public string InspectionNotes { get; set; } = null!;
        public long? LinkedSoporderReturnLineId { get; set; }
        public long? CreatedSopreturnLineId { get; set; }
    }
}
