using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabqrlogin
    {
        public long SiconWabqrloginId { get; set; }
        public long? WarehouseId { get; set; }
        public string? WarehouseName { get; set; }
        public string? ImgPath { get; set; }
        public string? WebApiurl { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
    }
}
