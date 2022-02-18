using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class EntrySource
    {
        public EntrySource()
        {
            AllocationBalances = new HashSet<AllocationBalance>();
            IntrastatEntries = new HashSet<IntrastatEntry>();
            MovementBalances = new HashSet<MovementBalance>();
            TransactionArchives = new HashSet<TransactionArchive>();
            TransactionHistories = new HashSet<TransactionHistory>();
        }

        public long EntrySourceId { get; set; }
        public string EntrySourceName { get; set; } = null!;

        public virtual ICollection<AllocationBalance> AllocationBalances { get; set; }
        public virtual ICollection<IntrastatEntry> IntrastatEntries { get; set; }
        public virtual ICollection<MovementBalance> MovementBalances { get; set; }
        public virtual ICollection<TransactionArchive> TransactionArchives { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}
