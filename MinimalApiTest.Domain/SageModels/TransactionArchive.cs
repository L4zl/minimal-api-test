using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TransactionArchive
    {
        public TransactionArchive()
        {
            TraceableTransArchives = new HashSet<TraceableTransArchive>();
        }

        public long TransactionArchiveId { get; set; }
        public long ItemId { get; set; }
        public long TransactionTypeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal Quantity { get; set; }
        public long SourceAreaTypeId { get; set; }
        public string SourceAreaReference { get; set; } = null!;
        public string SourceAreaName { get; set; } = null!;
        public string Reference { get; set; } = null!;
        public string SecondReference { get; set; } = null!;
        public string WarehouseName { get; set; } = null!;
        public string BinName { get; set; } = null!;
        public decimal UnitCostPrice { get; set; }
        public decimal UnitIssuePrice { get; set; }
        public decimal UnitDiscountValue { get; set; }
        public decimal CostValue { get; set; }
        public decimal IssueValue { get; set; }
        public decimal TotalOrderDiscount { get; set; }
        public bool NominalUpdated { get; set; }
        public string AnalysisCode1 { get; set; } = null!;
        public string AnalysisCode2 { get; set; } = null!;
        public string AnalysisCode3 { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public long? EntrySourceId { get; set; }
        public long PostingUrn { get; set; }
        public short PostingSource { get; set; }
        public int PostingUser { get; set; }
        public DateTime? PostedDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? OriginalTransactionId { get; set; }
        public string AnalysisCode4 { get; set; } = null!;
        public string AnalysisCode5 { get; set; } = null!;
        public string AnalysisCode6 { get; set; } = null!;
        public string AnalysisCode7 { get; set; } = null!;
        public string AnalysisCode8 { get; set; } = null!;
        public string AnalysisCode9 { get; set; } = null!;
        public string AnalysisCode10 { get; set; } = null!;
        public string AnalysisCode11 { get; set; } = null!;
        public string AnalysisCode12 { get; set; } = null!;
        public string AnalysisCode13 { get; set; } = null!;
        public string AnalysisCode14 { get; set; } = null!;
        public string AnalysisCode15 { get; set; } = null!;
        public string AnalysisCode16 { get; set; } = null!;
        public string AnalysisCode17 { get; set; } = null!;
        public string AnalysisCode18 { get; set; } = null!;
        public string AnalysisCode19 { get; set; } = null!;
        public string AnalysisCode20 { get; set; } = null!;
        public string VersionNumber { get; set; } = null!;
        public string UserRevisionNumber { get; set; } = null!;
        public string Memo { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual EntrySource? EntrySource { get; set; }
        public virtual StockItem Item { get; set; } = null!;
        public virtual SourceAreaType SourceAreaType { get; set; } = null!;
        public virtual TransactionType TransactionType { get; set; } = null!;
        public virtual ICollection<TraceableTransArchive> TraceableTransArchives { get; set; }
    }
}
