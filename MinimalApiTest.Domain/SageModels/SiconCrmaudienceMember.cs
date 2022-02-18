using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmaudienceMember
    {
        public long SiconCrmaudienceMemberId { get; set; }
        public long SiconCrmaudienceId { get; set; }
        public long SiconCrmpersonId { get; set; }
        public string MailChimpMemberId { get; set; } = null!;
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
    }
}
