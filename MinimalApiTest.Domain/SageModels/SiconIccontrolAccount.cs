using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconIccontrolAccount
    {
        public long SiconIccontrolAccountId { get; set; }
        public long? CompanyNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyShortName { get; set; }
        public long? NlnominalAccountId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long? CbaccountId { get; set; }
        public string? ProjectCode { get; set; }
        public string? ProjectItem { get; set; }
        public string? InternalArea { get; set; }
        public bool? ForceJournalPosting { get; set; }
        public string? Ccoverride { get; set; }
        public string? DeptOverride { get; set; }
        public bool? Vatrated { get; set; }
        public bool? IsEnabled { get; set; }
        public long? SalesNlnominalAccountId { get; set; }
        public long? PurchaseNlnominalAccountId { get; set; }
    }
}
