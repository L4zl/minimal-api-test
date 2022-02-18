using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsaitemplate
    {
        public long SiconDmsaitemplateId { get; set; }
        public string SupplierErpid { get; set; } = null!;
        public string TemplateName { get; set; } = null!;
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
