using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconPopstagedNomAccSetting
    {
        public long SiconPopstagedNomAccSettingId { get; set; }
        public bool? IsEnabled { get; set; }
        public long? OutstandingNlnominalAccountId { get; set; }
        public bool? IsGrniaccrualEnabled { get; set; }
        public long? GrniNlnominalAccountId { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public DateTime LastUpdatedDateTime { get; set; }
    }
}
