using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmstockItemSetting
    {
        public long SiSmstockItemSettingId { get; set; }
        public long ItemId { get; set; }
        public bool? ServiceableItem { get; set; }
        public bool? RequiresInstallationCase { get; set; }
        public string? DefaultMake { get; set; }
        public string? DefaultModel { get; set; }
        public string? ServiceIntervalMeasurement { get; set; }
        public string? WarrantyMeasurement { get; set; }
        public int? ServiceIntervalDuration { get; set; }
        public int? WarrantyDuration { get; set; }
        public bool? RequiresSeparateCase { get; set; }
        public long? SiSmcaseTypeId { get; set; }
        public bool? CreateEquipmentWithQuantity { get; set; }
        public long? SiSmserviceTemplateId { get; set; }
    }
}
