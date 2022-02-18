using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SysaccountingPeriod
    {
        public SysaccountingPeriod()
        {
            CbpendAccountTrans = new HashSet<CbpendAccountTran>();
            CbpostedAccountTrans = new HashSet<CbpostedAccountTran>();
            FadepreciationTrans = new HashSet<FadepreciationTran>();
            NlaccountPeriodValues = new HashSet<NlaccountPeriodValue>();
            NlbudgetApportPeriodPrcnts = new HashSet<NlbudgetApportPeriodPrcnt>();
            NlhistoricalNominalTrans = new HashSet<NlhistoricalNominalTran>();
            NlpostedNominalTrans = new HashSet<NlpostedNominalTran>();
            PcprojectEntries = new HashSet<PcprojectEntry>();
            PcprojectItemBudgetPdHistories = new HashSet<PcprojectItemBudgetPdHistory>();
            PcprojectItemBudgetPdValues = new HashSet<PcprojectItemBudgetPdValue>();
            PlhistRevalAllocationTrans = new HashSet<PlhistRevalAllocationTran>();
            PlhistoricalSupplierTrans = new HashSet<PlhistoricalSupplierTran>();
            PlpostedSupplierTrans = new HashSet<PlpostedSupplierTran>();
            PlrevalAllocationTrans = new HashSet<PlrevalAllocationTran>();
            SlhistRevalAllocationTrans = new HashSet<SlhistRevalAllocationTran>();
            SlhistoricalCustomerTrans = new HashSet<SlhistoricalCustomerTran>();
            SlpostedCustomerTrans = new HashSet<SlpostedCustomerTran>();
            SlrevalAllocationTrans = new HashSet<SlrevalAllocationTran>();
            SysmoduleAccountingPeriods = new HashSet<SysmoduleAccountingPeriod>();
            SystaxTrans = new HashSet<SystaxTran>();
        }

        public long SysaccountingPeriodId { get; set; }
        public long SysfinancialYearId { get; set; }
        public short PeriodNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SysfinancialYear SysfinancialYear { get; set; } = null!;
        public virtual ICollection<CbpendAccountTran> CbpendAccountTrans { get; set; }
        public virtual ICollection<CbpostedAccountTran> CbpostedAccountTrans { get; set; }
        public virtual ICollection<FadepreciationTran> FadepreciationTrans { get; set; }
        public virtual ICollection<NlaccountPeriodValue> NlaccountPeriodValues { get; set; }
        public virtual ICollection<NlbudgetApportPeriodPrcnt> NlbudgetApportPeriodPrcnts { get; set; }
        public virtual ICollection<NlhistoricalNominalTran> NlhistoricalNominalTrans { get; set; }
        public virtual ICollection<NlpostedNominalTran> NlpostedNominalTrans { get; set; }
        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
        public virtual ICollection<PcprojectItemBudgetPdHistory> PcprojectItemBudgetPdHistories { get; set; }
        public virtual ICollection<PcprojectItemBudgetPdValue> PcprojectItemBudgetPdValues { get; set; }
        public virtual ICollection<PlhistRevalAllocationTran> PlhistRevalAllocationTrans { get; set; }
        public virtual ICollection<PlhistoricalSupplierTran> PlhistoricalSupplierTrans { get; set; }
        public virtual ICollection<PlpostedSupplierTran> PlpostedSupplierTrans { get; set; }
        public virtual ICollection<PlrevalAllocationTran> PlrevalAllocationTrans { get; set; }
        public virtual ICollection<SlhistRevalAllocationTran> SlhistRevalAllocationTrans { get; set; }
        public virtual ICollection<SlhistoricalCustomerTran> SlhistoricalCustomerTrans { get; set; }
        public virtual ICollection<SlpostedCustomerTran> SlpostedCustomerTrans { get; set; }
        public virtual ICollection<SlrevalAllocationTran> SlrevalAllocationTrans { get; set; }
        public virtual ICollection<SysmoduleAccountingPeriod> SysmoduleAccountingPeriods { get; set; }
        public virtual ICollection<SystaxTran> SystaxTrans { get; set; }
    }
}
