using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconAppointment
    {
        public long SiconAppointmentId { get; set; }
        public int? Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? AllDay { get; set; }
        public string? Subject { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public int? Status { get; set; }
        public int? Label { get; set; }
        public string? ResourceIds { get; set; }
        public string? ReminderInfo { get; set; }
        public string? RecurrenceInfo { get; set; }
        public long? BorderObjectId { get; set; }
        public long? SiconLabelId { get; set; }
        public string? ICalGuid { get; set; }
        public int? ICalSequence { get; set; }
        public bool? ICalInvitationSent { get; set; }
        public bool? CalloutCharged { get; set; }
        public string? AppointmentContactEmail { get; set; }
        public byte[]? ArrivalSignatureByte { get; set; }
        public string? ArrivalSignedBy { get; set; }
        public byte[]? DepartureSignatureByte { get; set; }
        public string? DepartureSignedBy { get; set; }
        public decimal? BoxesLeft { get; set; }
        public string? BoxesComment { get; set; }
        public string? WorkDescription { get; set; }
        public string? FurtherAction { get; set; }
        public bool? IsWorkComplete { get; set; }
        public bool? FurtherActionAcknowledged { get; set; }
        public bool? IsWorkCompleteAcknowledged { get; set; }
        public bool? ConfirmationEmailSent { get; set; }
        public string? FromAddress1 { get; set; }
        public string? FromAddress2 { get; set; }
        public string? FromAddress3 { get; set; }
        public string? FromAddress4 { get; set; }
        public string? FromAddressCity { get; set; }
        public string? FromCounty { get; set; }
        public string? FromPostcode { get; set; }
        public string? ToAddress1 { get; set; }
        public string? ToAddress2 { get; set; }
        public string? ToAddress3 { get; set; }
        public string? ToAddress4 { get; set; }
        public string? ToAddressCity { get; set; }
        public string? ToCounty { get; set; }
        public string? ToPostcode { get; set; }
        public decimal? Mileage { get; set; }
        public decimal? TravelTimeEstimate { get; set; }
        public long? SiSmcaseId { get; set; }
        public DateTime? ActualStartTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public decimal? ActualHours { get; set; }
        public long? ChargeRateId { get; set; }
        public decimal? InvoicedHours { get; set; }
        public bool? Confirmed { get; set; }
        public string? SignedBy { get; set; }
        public int? NumberForCase { get; set; }
        public long? ParentAppointmentId { get; set; }
        public int? SubTypeId { get; set; }
        public int? TravelType { get; set; }
        public string? ArrivalSignaturePath { get; set; }
        public string? DepartureSignaturePath { get; set; }
        public bool? Downloaded { get; set; }
        public DateTime? QuestionsCompletedDate { get; set; }
        public long? SiSmcaseTrackingStatusId { get; set; }
        public long? CalloutRevenueSiJcTrnId { get; set; }
        public string? WorkBriefing { get; set; }
        public decimal? SubContractorQuote { get; set; }
        public string? CaseLocationDesc { get; set; }
        public string? CaseSummary { get; set; }
        public bool? Deleted { get; set; }
        public decimal? ArrivalLatitude { get; set; }
        public decimal? ArrivalLongitude { get; set; }
        public decimal? DepartureLatitude { get; set; }
        public decimal? DepartureLongitude { get; set; }
        public long? SiconContractLineId { get; set; }
        public int? CalloutBillingPlan { get; set; }
        public long? MileageExpenseId { get; set; }
        public long? SiOperationId { get; set; }
        public string? CustomerName { get; set; }
    }
}
