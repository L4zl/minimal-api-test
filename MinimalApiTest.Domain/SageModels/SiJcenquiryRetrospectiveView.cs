using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiJcenquiryRetrospectiveView
    {
        public long? SysaccountingPeriodId { get; set; }
        public long? SysfinancialYearId { get; set; }
        public short? PeriodNumber { get; set; }
        public int? AccountingPeriodYear { get; set; }
        public DateTime? EndDate { get; set; }
        public long? Sijctrnid { get; set; }
        public string Transtype { get; set; } = null!;
        public string? Stocktype { get; set; }
        public DateTime? Transdate { get; set; }
        public string? DocumentReference { get; set; }
        public long PoporderReturnLineId { get; set; }
        public long SoporderReturnLineId { get; set; }
        public long? Sijcjobid { get; set; }
        public string? Jobnumber { get; set; }
        public long? Sijcchdid { get; set; }
        public string? Costcode { get; set; }
        public string? Headertype { get; set; }
        public bool Billed { get; set; }
        public string? Stockitemtext { get; set; }
        public long SoporderReturnId { get; set; }
        public long PoporderReturnId { get; set; }
        public int ReportGroup1 { get; set; }
        public int ReportGroup2 { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? CommitQuantity { get; set; }
        public decimal? ActualQuantity { get; set; }
        public decimal? Unitvalue { get; set; }
        public long PlsupplierAccountId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long? Stockitemid { get; set; }
        public long? Sijcempid { get; set; }
        public DateTime? Updateddate { get; set; }
        public bool? DisplayNoCosts { get; set; }
        public bool? IsPopvariance { get; set; }
        public decimal? AutoIssuedQuantity { get; set; }
        public string? InvoiceCreditNumber { get; set; }
        public DateTime? ReportingDate { get; set; }
        public long? PlpostedSupplierTranId { get; set; }
        public long? SlpostedCustomerTranId { get; set; }
        public long? SiJobPhaseId { get; set; }
        public long? SiJobStageId { get; set; }
        public long? SiJobSubStageId { get; set; }
        public long? SiOperationId { get; set; }
        public long? SiJcVariationId { get; set; }
        public decimal? CommittedValue { get; set; }
        public decimal? ActualValue { get; set; }
        public string ReportTransType { get; set; } = null!;
        public long RecordGroupingId { get; set; }
    }
}
