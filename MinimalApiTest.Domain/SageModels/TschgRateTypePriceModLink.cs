using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TschgRateTypePriceModLink
    {
        public long TschgRateTypePriceModLinkId { get; set; }
        public long TschargeRateTypeId { get; set; }
        public long PctimeMaterialsPriceRuleId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PctimeMaterialsPriceRule PctimeMaterialsPriceRule { get; set; } = null!;
        public virtual TschargeRateType TschargeRateType { get; set; } = null!;
    }
}
