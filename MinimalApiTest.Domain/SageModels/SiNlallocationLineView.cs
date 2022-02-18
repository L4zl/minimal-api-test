using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiNlallocationLineView
    {
        public long NlpostedNominalTranId { get; set; }
        public decimal OutstandingAmount { get; set; }
        public long NlnominalAccountId { get; set; }
        public long? SiNlallocationLineId { get; set; }
        public long? NlallocationId { get; set; }
        public long SysaccountingPeriodId { get; set; }
        public long NlnominalTranTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal GoodsValueInBaseCurrency { get; set; }
        public decimal GoodsValueInDocumentCurrency { get; set; }
        public long DocumentCurrencyId { get; set; }
        public decimal ExchangeRate { get; set; }
        public string Reference { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public int UserNumber { get; set; }
        public long Source { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public short? PeriodNumber { get; set; }
        public string? Name { get; set; }
    }
}
