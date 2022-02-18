using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopreceiptReturn
    {
        public PopreceiptReturn()
        {
            PopreceiptReturnLines = new HashSet<PopreceiptReturnLine>();
        }

        public long PopreceiptReturnId { get; set; }
        public long PopreceiptReturnTypeId { get; set; }
        public string DocumentNo { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public string SupplierDocumentNo { get; set; } = null!;
        public DateTime? SupplierDocumentDate { get; set; }
        public string Narrative { get; set; } = null!;
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopreceiptReturnType PopreceiptReturnType { get; set; } = null!;
        public virtual ICollection<PopreceiptReturnLine> PopreceiptReturnLines { get; set; }
    }
}
