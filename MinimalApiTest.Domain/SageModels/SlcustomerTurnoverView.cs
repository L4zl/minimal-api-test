using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerTurnoverView
    {
        public string? MmssltPeriodReference { get; set; }
        public DateTime MmssltStartDate { get; set; }
        public DateTime MmssltEndDate { get; set; }
        public double? MmssltTotalInvoiceValueToDate { get; set; }
        public double? MmssltTotalCreditNoteValueToDate { get; set; }
        public double? MmssltTotalCashValueToDate { get; set; }
        public double? MmssltTotalProfitValueToDate { get; set; }
        public double? MmssltTotalInvoiceValueToDateInBase { get; set; }
        public double? MmssltTotalCredNoteValueToDateInBase { get; set; }
        public double? MmssltTotalCashValueToDateInBase { get; set; }
        public double? MmssltTotalProfitValueToDateInBase { get; set; }
        public double? MmssltExchangeRateGainOrLoss { get; set; }
        public double? MmssltTotalFinanceChargesApplied { get; set; }
        public long MmssltSlcustomerPeriodValueId { get; set; }
        public string MmssltCustomerAccountNumber { get; set; } = null!;
    }
}
