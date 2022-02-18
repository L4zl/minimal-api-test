using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobHireOrder
    {
        public long SiconJobHireOrderId { get; set; }
        public long? SiJcjobId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public string? HireReference { get; set; }
        public long? PoporderReturnId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobActivityId { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
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
        public string? RequestedBy { get; set; }
        public string? EnteredBy { get; set; }
        public decimal? CostTotal { get; set; }
        public string? HireOrderStatus { get; set; }
        public string? AddressCounty { get; set; }
        public string? AddressCountry { get; set; }
        public long? SiconJobAddressId { get; set; }
        public bool? MultiJobOrder { get; set; }
    }
}
