using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconProjectEmployeeView
    {
        public long SiJcEmpId { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public long? EmployeeNumber { get; set; }
        public string? PayrollReference { get; set; }
        public string? Ninumber { get; set; }
        public string? Team { get; set; }
        public string? Email { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostCode { get; set; }
        public string? AddressCountry { get; set; }
        public string? ExternalTeam { get; set; }
        public bool? IsTeamLeader { get; set; }
        public DateTime? StartDate { get; set; }
        public string? DefaultProjectHeader { get; set; }
        public string? ChargeWorkPattern { get; set; }
        public string? CostWorkPattern { get; set; }
        public bool? SubContractor { get; set; }
        public DateTime? ContractExpiryDate { get; set; }
        public string? SubContractorAccountNumber { get; set; }
        public string? SubContractorAccountName { get; set; }
        public long? NextInvNo { get; set; }
        public bool? IsDormant { get; set; }
        public string? AnalysisCode1 { get; set; }
        public string? AnalysisCode2 { get; set; }
        public string? AnalysisCode3 { get; set; }
        public string? AnalysisCode4 { get; set; }
        public string? AnalysisCode5 { get; set; }
    }
}
