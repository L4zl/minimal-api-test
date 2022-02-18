using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconTeam
    {
        public long SiJcRoleId { get; set; }
        public string? Name { get; set; }
        public string? Reference { get; set; }
        public long? SiJcChdId { get; set; }
        public bool? Internal { get; set; }
        public long? SiconTeamGroupId { get; set; }
        public long? LabLabourResourceId { get; set; }
        public decimal? CostRate { get; set; }
        public long? SiJcWorkPatternCostId { get; set; }
        public long? SiJcWorkPatternChargeId { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressCity { get; set; }
        public string? AddressPostCode { get; set; }
        public string? MobileNumber { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? Email { get; set; }
        public long? MachMachineResourceId { get; set; }
        public string? TeamType { get; set; }
        public int? DefaultEmployeeCount { get; set; }
    }
}
