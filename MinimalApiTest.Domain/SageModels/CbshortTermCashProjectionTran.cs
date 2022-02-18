using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class CbshortTermCashProjectionTran
    {
        public long CbshortTermCashProjectionTranId { get; set; }
        public long CbshortTermCashProjectionHeaderId { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public long? SlpostedCustomerTranId { get; set; }
        public long? CbdirectDebitTranId { get; set; }
        public DateTime ForecastDate { get; set; }
        public string Type { get; set; } = null!;
        public DateTime DueDate { get; set; }
        public string? AccountName { get; set; }
        public bool IncludeInForecast { get; set; }
        public string QueryCode { get; set; } = null!;
        public string Details { get; set; } = null!;
        public decimal Receipt { get; set; }
        public decimal Payment { get; set; }

        public virtual CbdirectDebitTran? CbdirectDebitTran { get; set; }
        public virtual CbshortTermCashProjectionHeader CbshortTermCashProjectionHeader { get; set; } = null!;
        public virtual PlpostedSupplierTran? PlpostedSupplierTran { get; set; }
        public virtual SlpostedCustomerTran? SlpostedCustomerTran { get; set; }
    }
}
