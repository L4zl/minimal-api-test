using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJobHireOrderView
    {
        public long SiconJobHireOrderId { get; set; }
        public string? Jobnumber { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public string? HireReference { get; set; }
        public string? Ponumber { get; set; }
        public decimal? CostTotal { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressContact { get; set; }
        public string? AddressEmail { get; set; }
        public string? AddressFax { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressPostalName { get; set; }
        public string? AddressCounty { get; set; }
        public string? AddressCountry { get; set; }
        public string? AddressPostCode { get; set; }
        public string? AddressTelephone { get; set; }
        public string? RequestedBy { get; set; }
        public string? EnteredBy { get; set; }
        public string? HireOrderStatus { get; set; }
    }
}
