﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobHire
    {
        public long SiconJobHireId { get; set; }
        public long? SiJcjobId { get; set; }
        public long? SiJcchdId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? HireReference { get; set; }
        public long? ItemId { get; set; }
        public string? Description { get; set; }
        public decimal? QuantityOnHire { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Duration { get; set; }
        public string? DurationType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? PoporderReturnLineId { get; set; }
        public string? HireStatus { get; set; }
        public long? SiJcvariationId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public string? ReceiptReference { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? OffHireReference { get; set; }
        public DateTime? OffHireDate { get; set; }
        public string? CollectionReference { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? DeletedByUserId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? TaxCodeId { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TaxValue { get; set; }
        public string? AddressPostalName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostCode { get; set; }
        public string? AddressContact { get; set; }
        public string? AddressTelephone { get; set; }
        public string? AddressFax { get; set; }
        public string? AddressEmail { get; set; }
        public long? CustDeliveryAddressId { get; set; }
        public DateTime? OriginalStartDate { get; set; }
        public DateTime? OriginalEndDate { get; set; }
        public bool? ExcludeWeekends { get; set; }
        public string? RequestedBy { get; set; }
        public string? EnteredBy { get; set; }
        public string? FleetNumber { get; set; }
        public long? SiconJobHireOrderId { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public long? CommittedSiJcTrnId { get; set; }
        public string? AddressCounty { get; set; }
        public string? AddressCountry { get; set; }
        public bool? AwaitingApproval { get; set; }
        public string? AwaitingApprovalBy { get; set; }
        public long? OwnedPlantId { get; set; }
    }
}