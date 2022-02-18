using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiOperation
    {
        public long SiOperationId { get; set; }
        public long? SiOperationHeaderId { get; set; }
        public long? SiJcJobId { get; set; }
        public long? SiWorksOrderId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public long? SiJcVariationId { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? OperationType { get; set; }
        public DateTime? OperationDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Comment { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public int? Sequence { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public decimal? Pccomplete { get; set; }
        public string? ThirdPartyReference { get; set; }
        public string? AssignedToUser { get; set; }
        public string? Barcode { get; set; }
        public decimal? QuantityCompleted { get; set; }
        public decimal? ExpectedHours { get; set; }
        public decimal? TotalQuantity { get; set; }
        public string? DocumentNo { get; set; }
        public bool? Completed { get; set; }
        public bool? OnHold { get; set; }
        public bool? Deleted { get; set; }
        public string? ResourceDescription { get; set; }
        public bool? Scheduled { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string? CreatedByUserId { get; set; }
        public decimal? QuantityPerRun { get; set; }
        public decimal? DefaultRunTimeHours { get; set; }
        public decimal? DefaultRunTimeMinutes { get; set; }
        public decimal? DefaultRunTimeSeconds { get; set; }
        public decimal? ReworkQuantity { get; set; }
        public bool? FixedLength { get; set; }
        public bool? InspectionPassed { get; set; }
        public bool? Inspection { get; set; }
        public long? OpOperationId { get; set; }
        public decimal? SiWoquantityCompleted { get; set; }
        public DateTime? TimesheetStartDateTime { get; set; }
    }
}
