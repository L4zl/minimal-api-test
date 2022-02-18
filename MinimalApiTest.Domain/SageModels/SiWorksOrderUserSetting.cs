using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiWorksOrderUserSetting
    {
        public long SiWorksOrderUserSettingId { get; set; }
        public int UserNumber { get; set; }
        public long? FinishedItemWarehouseId { get; set; }
        public long? ComponentWarehouseId { get; set; }
        public bool? DisableWorksOrderModification { get; set; }
    }
}
