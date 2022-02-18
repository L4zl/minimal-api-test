using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconRetentionSupCusSetting
    {
        public long SiconRetentionSupCusSettingId { get; set; }
        public long? SlcustomerAccountId { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public decimal? RetentionPercentage { get; set; }
        public int? RetentionDuration { get; set; }
        public int? ApplicationDuration { get; set; }
        public bool AppsRequireInvoice { get; set; }
        public bool ApplyCis { get; set; }
        public decimal? RetentionPercentage2 { get; set; }
        public decimal? RetentionPercentage3 { get; set; }
        public decimal? RetentionPercentage4 { get; set; }
        public bool? CappedRetention { get; set; }
        public decimal? CappedRetentionLimit { get; set; }
        public int? RetentionDuration1 { get; set; }
        public int? RetentionDuration2 { get; set; }
        public int? RetentionDuration3 { get; set; }
        public int? RetentionDuration4 { get; set; }
    }
}
