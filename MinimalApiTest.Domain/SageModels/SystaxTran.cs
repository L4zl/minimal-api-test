using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxTran
    {
        public long SystaxTranId { get; set; }
        public string? AccountNumber { get; set; }
        public string? CostCentre { get; set; }
        public string? Department { get; set; }
        public decimal GoodsAmount { get; set; }
        public string Reference { get; set; } = null!;
        public long Source { get; set; }
        public DateTime TaxPointDate { get; set; }
        public DateTime PostedDate { get; set; }
        public long SystaxTranTypeId { get; set; }
        public long UniqueReferenceNumber { get; set; }
        public int UserNumber { get; set; }
        public decimal VatAmount { get; set; }
        public DateTime? VatReturnDate { get; set; }
        public long SystaxRateId { get; set; }
        public long SystaxPeriodRateBalanceId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public long? NominalAccountingPeriodId { get; set; }
        public bool TriangularTransaction { get; set; }
        public decimal EsvatDiscountAmount { get; set; }
        public bool IsSettledImmediately { get; set; }
        public bool IsVatadjustmentDocumentExpected { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public string TaxAnalysisDetails { get; set; } = null!;
        public string TaxRegistrationNumber { get; set; } = null!;

        public virtual SysaccountingPeriod? NominalAccountingPeriod { get; set; }
        public virtual SystaxPeriodRateBalance SystaxPeriodRateBalance { get; set; } = null!;
        public virtual SystaxRate SystaxRate { get; set; } = null!;
        public virtual SystaxTranType SystaxTranType { get; set; } = null!;
    }
}
