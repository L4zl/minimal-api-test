using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconJctimesheetJournal
    {
        public long SiconJctimesheetJournalId { get; set; }
        public long? SiJcJobId { get; set; }
        public string? JobNumber { get; set; }
        public long? SiJcChdId { get; set; }
        public string? CostCode { get; set; }
        public long? SiJcTrnId { get; set; }
        public DateTime? TranDate { get; set; }
        public decimal? Qty { get; set; }
        public decimal? UnitValue { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string? Narrative { get; set; }
        public long? NlnominalAccountId { get; set; }
        public string? Nlreference { get; set; }
        public string? Nlcc { get; set; }
        public string? Nldept { get; set; }
        public string? Nlname { get; set; }
        public string? JournalStatus { get; set; }
        public string? JournalPostingRef { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public long? JournalSijctrnid { get; set; }
    }
}
