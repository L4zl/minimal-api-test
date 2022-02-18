using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderReturnIncArchView
    {
        public long SoporderReturnId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public long DocumentStatusId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public long CustomerId { get; set; }
        public long DocumentTypeId { get; set; }
        public bool? IsArchived { get; set; }
    }
}
