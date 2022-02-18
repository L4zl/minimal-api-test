using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCrmcampaign
    {
        public long SiconCrmcampaignId { get; set; }
        public long SiconCrmaudienceId { get; set; }
        public string CampaignName { get; set; } = null!;
        public string FromAddress { get; set; } = null!;
        public string FromName { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string MailChimpCampaignId { get; set; } = null!;
        public bool? Deleted { get; set; }
        public string CreatedUser { get; set; } = null!;
        public DateTime? CreatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
        public DateTime? UpdatedDate { get; set; }
    }
}
