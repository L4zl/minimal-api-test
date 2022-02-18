using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmorder
    {
        public long SiconHmorderId { get; set; }
        public string? HireOrderNumber { get; set; }
        public long? SiconHmdocumentStatusId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? SiconHmorderTypeId { get; set; }
        public string? CreatedBy { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public long? SiconContactPersonId { get; set; }
        public string? Details { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
        public string? Description { get; set; }
        public string? CustomerRef { get; set; }
        public string? OrderedBy { get; set; }
        public bool? BillingComplete { get; set; }
        public string? DeliveryPostalName { get; set; }
        public string? DeliveryAddressLine1 { get; set; }
        public string? DeliveryAddressLine2 { get; set; }
        public string? DeliveryAddressLine3 { get; set; }
        public string? DeliveryAddressLine4 { get; set; }
        public string? DeliveryCity { get; set; }
        public string? DeliveryPostCode { get; set; }
        public string? DeliveryContact { get; set; }
        public string? DeliveryTelephoneNo { get; set; }
        public string? DeliveryFaxNo { get; set; }
        public string? DeliveryEmailAddress { get; set; }
        public string? DeliveryCounty { get; set; }
        public string? DeliveryCountry { get; set; }
        public long? SiJcJobId { get; set; }
        public long? WarehouseId { get; set; }
        public bool? OverrideCustomerDiscount { get; set; }
        public decimal? InvoiceDiscount { get; set; }
        public decimal? DefaultInvoiceLineDiscount { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
        public string? AnalysisCode6 { get; set; }
        public string? AnalysisCode7 { get; set; }
        public string? AnalysisCode8 { get; set; }
        public string? AnalysisCode9 { get; set; }
        public string? AnalysisCode10 { get; set; }
        public string? AnalysisCode11 { get; set; }
        public string? AnalysisCode12 { get; set; }
        public string? AnalysisCode13 { get; set; }
        public string? AnalysisCode14 { get; set; }
        public string? AnalysisCode15 { get; set; }
        public string? AnalysisCode16 { get; set; }
        public string? AnalysisCode17 { get; set; }
        public string? AnalysisCode18 { get; set; }
        public string? AnalysisCode19 { get; set; }
        public string? AnalysisCode20 { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string? LastUpdatedUser { get; set; }
        public long? ConvertedToOrderId { get; set; }
        public decimal? DepositAmount { get; set; }
        public bool? CreateDeposit { get; set; }
        public decimal? DepositPercent { get; set; }
        public long? DepositSoporderReturnId { get; set; }
        public decimal? DepositAmountUsed { get; set; }
        public DateTime? DepositDate { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTelephone { get; set; }
        public string? ContactEmail { get; set; }
        public long? SlcustomerContactId { get; set; }
        public decimal? TotalInvoicedToDate { get; set; }
        public decimal? TotalRemainingToBeInvoiced { get; set; }
        public DateTime? OffHireDate { get; set; }
        public DateTime? PoexpiryDate { get; set; }
        public int? LastSopdocumentNoSuffix { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string? WhoOrdered { get; set; }
        public string? WhoOffHired { get; set; }
        public string? OffHiredUser { get; set; }
        public bool? IsFoc { get; set; }
        public bool? ExcludeWeekends { get; set; }
        public long? SiconHmdocumentCustomStatusId { get; set; }
    }
}
