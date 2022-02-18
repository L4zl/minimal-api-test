using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsautoFieldDefinition
    {
        public long SiconDmsautoFieldDefinitionId { get; set; }
        public string FieldsJson { get; set; } = null!;
        public long? SiconDmsdocumentTypeEntityId { get; set; }
        public long? SiconDmsentityModuleId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
