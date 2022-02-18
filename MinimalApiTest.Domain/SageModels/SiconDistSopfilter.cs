using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistSopfilter
    {
        public long SiconDistSopfilterId { get; set; }
        public long SoporderId { get; set; }
        public string? CustomerOrderNo { get; set; }
        public DateTime? OrderDocumentDate { get; set; }
        public long SlcustomerAccountId { get; set; }
        public string? FilterName { get; set; }
        public string? DocumentStatus { get; set; }
        public bool? Deleted { get; set; }
        public string? UpdatedUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
