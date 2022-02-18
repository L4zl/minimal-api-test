using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiConstructionSettingsView
    {
        public string? HmrccontractorUtr { get; set; }
        public string? HmrcaccountsOfficeRef { get; set; }
        public string? HmrcsenderId { get; set; }
        public string? HmrctaxOfficeNumber { get; set; }
        public string? HmrctaxOfficeReference { get; set; }
        public string? Hmrcsender { get; set; }
        public string? Hmrconline { get; set; }
        public string? ContractorEmployeeReferenceNumber { get; set; }
        public string? SubcontractorPercentage1 { get; set; }
        public string? SubcontractorPercentage1Desc { get; set; }
        public string? SubcontractorPercentage2 { get; set; }
        public string? SubcontractorPercentage2Desc { get; set; }
        public string? SubcontractorPercentage3 { get; set; }
        public string? SubcontractorPercentage3Desc { get; set; }
        public string? ReverseChargeVatcode { get; set; }
    }
}
