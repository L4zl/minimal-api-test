using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PlsupplierYearValue
    {
        public long PlsupplierYearValueId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long SysfinancialYearId { get; set; }
        public decimal TotalInvoiceValueToDate { get; set; }
        public decimal TotalCreditNoteValueToDate { get; set; }
        public decimal TotalCashValueToDate { get; set; }
        public decimal TotalProfitValueToDate { get; set; }
        public decimal TotalInvoiceValueToDateInBase { get; set; }
        public decimal TotalCredNoteValueToDateInBase { get; set; }
        public decimal TotalCashValueToDateInBase { get; set; }
        public decimal TotalProfitValueToDateInBase { get; set; }
        public decimal ExchangeRateGainOrLoss { get; set; }
        public decimal TotalFinanceChargesApplied { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PlsupplierAccount PlsupplierAccount { get; set; } = null!;
        public virtual SysfinancialYear SysfinancialYear { get; set; } = null!;
    }
}
