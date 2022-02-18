using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmhistory
    {
        public long SiconHmhistoryId { get; set; }
        public long? SiconHmorderId { get; set; }
        public DateTime? HistoryDateTime { get; set; }
        public string? SageUser { get; set; }
        public string? Details { get; set; }
        public string? ReportPath { get; set; }
        public long? HistoryTransactionTypeId { get; set; }
        public DateTime? TransactionDateTime { get; set; }
    }
}
