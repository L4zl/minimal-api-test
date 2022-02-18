using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconContractOrderLinkView
    {
        public long? SiconContractId { get; set; }
        public long SoporderReturnId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public bool? IsArchived { get; set; }
        public long DocumentTypeId { get; set; }
        public string OrderType { get; set; } = null!;
        public string OrderStatus { get; set; } = null!;
        public string Reason { get; set; } = null!;
    }
}
