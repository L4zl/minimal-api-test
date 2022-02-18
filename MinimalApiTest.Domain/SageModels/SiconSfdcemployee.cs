using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSfdcemployee
    {
        public long SiJcEmpId { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public long? Pin { get; set; }
        public bool? ShopFloorAppLicensed { get; set; }
        public string? Deleted { get; set; }
    }
}
