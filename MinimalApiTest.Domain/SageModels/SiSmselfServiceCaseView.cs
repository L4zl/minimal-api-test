using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmselfServiceCaseView
    {
        public long SiSmcaseId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public string? CaseNumber { get; set; }
        public string? CustomerOrderNumber { get; set; }
        public long? SiSmdocumentStatusId { get; set; }
        public long? SiSmdocumentSubStatusId { get; set; }
        public string DocStatus { get; set; } = null!;
        public DateTime? CallDate { get; set; }
        public string? Summary { get; set; }
        public string? Details { get; set; }
        public string FaultCode { get; set; } = null!;
        public string? LocationDescription { get; set; }
        public string? LocationPostalName { get; set; }
        public string? LocationAddressLine1 { get; set; }
        public string? LocationAddressLine2 { get; set; }
        public string? LocationAddressLine3 { get; set; }
        public string? LocationAddressLine4 { get; set; }
        public string? LocationCity { get; set; }
        public string? LocationCounty { get; set; }
        public string? LocationPostcode { get; set; }
        public string Priority { get; set; } = null!;
        public long? SiSmpriorityId { get; set; }
        public string? ContactName { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactTelephone { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public string? Solution { get; set; }
        public string? SubLocation { get; set; }
        public string CaseType { get; set; } = null!;
        public DateTime? LastAttachmentUpdateDate { get; set; }
        public string? LastTrackingStatus { get; set; }
        public DateTime? LastTrackingDateTime { get; set; }
        public string? AssignedToUserName { get; set; }
        public string? InternalTeam { get; set; }
        public string? ExternalTeam { get; set; }
        public string? Crmcompany { get; set; }
        public string? Crmperson { get; set; }
        public string? EndUserCompany { get; set; }
        public string? EndUserPerson { get; set; }
    }
}
