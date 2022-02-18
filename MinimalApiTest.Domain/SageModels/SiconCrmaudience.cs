using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmaudience
    {
        public long SiconCrmaudienceId { get; set; }
        public string MailChimpAudienceId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string DefaultFromAddress { get; set; } = null!;
        public string DefaultFromName { get; set; } = null!;
        public string DefaultSubject { get; set; } = null!;
        public string SignUpReminder { get; set; } = null!;
        public string ContactCompanyName { get; set; } = null!;
        public string ContactAddress1 { get; set; } = null!;
        public string ContactAddress2 { get; set; } = null!;
        public string ContactCity { get; set; } = null!;
        public string ContactPostCode { get; set; } = null!;
        public string ContactCountry { get; set; } = null!;
        public string ContactRegion { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public string Language { get; set; } = null!;
        public string NotifyOnSubscribeEmail { get; set; } = null!;
        public string NotifyOnUnSubscribeEmail { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
