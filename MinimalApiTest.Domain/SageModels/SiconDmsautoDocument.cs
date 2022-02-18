using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDmsautoDocument
    {
        public long SiconDmsautoDocumentId { get; set; }
        public string FileName { get; set; } = null!;
        public string OcrJson { get; set; } = null!;
        public string PagesJson { get; set; } = null!;
        public string LabelsJson { get; set; } = null!;
        public long SiconDmsautoFieldDefinitionId { get; set; }
        public long? SiconDmsdocumentTypeEntityId { get; set; }
        public long? SiconDmsentityModuleId { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
