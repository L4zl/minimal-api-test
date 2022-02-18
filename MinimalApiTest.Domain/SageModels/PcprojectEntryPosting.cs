using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectEntryPosting
    {
        public PcprojectEntryPosting()
        {
            BlbillLinePostings = new HashSet<BlbillLinePosting>();
            BlbilledTransactions = new HashSet<BlbilledTransaction>();
        }

        public long PcprojectEntryPostingId { get; set; }
        public long PcprojectEntryId { get; set; }
        public decimal AmountDocumentCurrency { get; set; }
        public DateTime ProjectEntryPostingDate { get; set; }
        public long SyscurrencyId { get; set; }
        public decimal AmountBaseCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal Quantity { get; set; }
        public long? BlbillLineId { get; set; }
        public long PcentryPostingStatusId { get; set; }
        public long? InvinvoiceCreditLineId { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual InvinvoiceCreditLine? InvinvoiceCreditLine { get; set; }
        public virtual PcentryPostingStatus PcentryPostingStatus { get; set; } = null!;
        public virtual PcprojectEntry PcprojectEntry { get; set; } = null!;
        public virtual ICollection<BlbillLinePosting> BlbillLinePostings { get; set; }
        public virtual ICollection<BlbilledTransaction> BlbilledTransactions { get; set; }
    }
}
