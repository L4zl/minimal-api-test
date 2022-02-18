using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsUserSetting
    {
        public long SiconDdsUserSettingId { get; set; }
        public int SageUserId { get; set; }
        public string SageUsername { get; set; } = null!;
        public bool SopamendPaymentMethod { get; set; }
        public bool SopamendPaymentDetails { get; set; }
        public bool SopamendBankPaymentDetails { get; set; }
        public bool SopviewBankPaymentDetails { get; set; }
        public bool SlamendPaymentMethod { get; set; }
        public bool SlamendPaymentDetails { get; set; }
        public bool SlamendBankPaymentDetails { get; set; }
        public bool SlviewBankPaymentDetails { get; set; }
        public bool CustomerAmendPaymentMethod { get; set; }
        public bool CustomerAmendPaymentDetails { get; set; }
        public bool CustomerAmendBankDetails { get; set; }
        public bool CustomerAmendAccountDetails { get; set; }
        public bool CustomerViewBankDetails { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
