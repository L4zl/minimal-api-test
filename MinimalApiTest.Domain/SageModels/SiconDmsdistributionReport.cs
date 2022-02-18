using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsdistributionReport
    {
        public long SiconDmsdistrubutionReportId { get; set; }
        public long SiconDmsdocumentTypeEntityId { get; set; }
        public long? SiconDmsentityModuleId { get; set; }
        public long? SystraderContactRoleId { get; set; }
        public short OutlookSendFlags { get; set; }
        public string HeaderFilename { get; set; } = null!;
        public string LetterheadFilename { get; set; } = null!;
        public string TermsAndConditionsFilename { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
