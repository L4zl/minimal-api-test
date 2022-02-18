using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJcallPlantItemsView
    {
        public long PlantId { get; set; }
        public long? ItemId { get; set; }
        public string? PlantItem { get; set; }
        public string PlantType { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public decimal? UnitCost { get; set; }
        public long? Sijcjobid { get; set; }
        public string? JobNumber { get; set; }
        public string? JobDescription { get; set; }
        public string? Phase { get; set; }
        public string? Stage { get; set; }
        public string? Activity { get; set; }
        public string? JobHeader { get; set; }
        public DateTime? PlantLastActivityDate { get; set; }
        public string? Employee { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
        public DateTime? LastCalibrationDate { get; set; }
        public DateTime? NextCalibrationDate { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public DateTime? NextServiceDate { get; set; }
        public string? HireReference { get; set; }
        public string PopdocumentNo { get; set; } = null!;
        public decimal? Duration { get; set; }
        public string? DurationType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? PlantStatus { get; set; }
        public string? ReceiptReference { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? OffHireReference { get; set; }
        public DateTime? OffHireDate { get; set; }
        public string? CollectionReference { get; set; }
        public DateTime? CollectionDate { get; set; }
        public string? AddressPostalName { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostCode { get; set; }
        public string? AddressContact { get; set; }
        public string? AddressTelephone { get; set; }
        public string? AddressEmail { get; set; }
        public string? AddressFax { get; set; }
        public DateTime? OriginalStartDate { get; set; }
        public DateTime? OriginalEndDate { get; set; }
        public string? EnteredBy { get; set; }
        public string? FleetNumber { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public string? SupplierAccountName { get; set; }
        public long? PlantNumber { get; set; }
        public DateTime? PlantPurchasedDate { get; set; }
        public decimal? PlantPurchasedPrice { get; set; }
    }
}
