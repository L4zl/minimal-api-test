using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDdsCsvformatSchema
    {
        public long SiconDdsCsvformatSchemaId { get; set; }
        public long? SiconDdsCsvformatHeaderId { get; set; }
        public long? SiconDdsCsvformatSchemaTypeId { get; set; }
        public string Caption { get; set; } = null!;
        public int Position { get; set; }
        public bool Deleted { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedUser { get; set; } = null!;
    }
}
