using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRctcontract
    {
        public long SiconRctcontractId { get; set; }
        public long? Sijcjobid { get; set; }
        public long? SupplierId { get; set; }
        public string? ContractNotificationId { get; set; }
        public string? NatureOfWork { get; set; }
        public string? RctprojectName { get; set; }
        public string? RctaddressLine1 { get; set; }
        public string? RctaddressLine2 { get; set; }
        public string? RctaddressLine3 { get; set; }
        public string? Rctcounty { get; set; }
        public int? RctcountyCode { get; set; }
        public string? Rcteirecode { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public decimal? EstimatedContractValue { get; set; }
        public string? VerificationNo { get; set; }
        public string? SiteIdentifierNo { get; set; }
        public string? RateDescription { get; set; }
    }
}
