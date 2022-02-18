using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SourceAreaType
    {
        public SourceAreaType()
        {
            AllocationBalances = new HashSet<AllocationBalance>();
            MovementBalances = new HashSet<MovementBalance>();
            TraceableItemArches = new HashSet<TraceableItemArch>();
            TraceableItems = new HashSet<TraceableItem>();
            TransactionArchives = new HashSet<TransactionArchive>();
            TransactionHistories = new HashSet<TransactionHistory>();
        }

        public long SourceAreaTypeId { get; set; }
        public string SourceAreaTypeName { get; set; } = null!;

        public virtual ICollection<AllocationBalance> AllocationBalances { get; set; }
        public virtual ICollection<MovementBalance> MovementBalances { get; set; }
        public virtual ICollection<TraceableItemArch> TraceableItemArches { get; set; }
        public virtual ICollection<TraceableItem> TraceableItems { get; set; }
        public virtual ICollection<TransactionArchive> TransactionArchives { get; set; }
        public virtual ICollection<TransactionHistory> TransactionHistories { get; set; }
    }
}
