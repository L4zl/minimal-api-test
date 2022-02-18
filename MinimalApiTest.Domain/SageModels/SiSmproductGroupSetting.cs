using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmproductGroupSetting
    {
        public long SiSmproductGroupSettingId { get; set; }
        public long ProductGroupId { get; set; }
        public long? SiSmserviceTemplateId { get; set; }
    }
}
