using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class NlpendNominalTranReport
    {
        public long NlpendNominalTranReportId { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string AccountCostCentre { get; set; } = null!;
        public string AccountDepartment { get; set; } = null!;
        public string PostingReferenceFormatStringDashes { get; set; } = null!;
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public decimal DebitValue { get; set; }
        public decimal CreditValue { get; set; }
    }
}
