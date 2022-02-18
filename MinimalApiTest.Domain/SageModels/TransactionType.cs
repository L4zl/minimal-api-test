using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            TransactionArchives = new HashSet<TransactionArchive>();
            TransactionHistories = new HashSet<TransactionHistory>();
        }

        public long TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; } = null!;
        public long TransactionGroupId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual TransactionGroup TransactionGroup { get; set; } = null!;
        public virtual ICollection<TransactionArchive> TransactionArchives { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}
