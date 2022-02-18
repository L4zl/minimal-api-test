using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Sysmodule
    {
        public Sysmodule()
        {
            NldeferredNominalTranNominalPeriodModuleNavigations = new HashSet<NldeferredNominalTran>();
            NldeferredNominalTranSourceNavigations = new HashSet<NldeferredNominalTran>();
            NlpendNominalTranNominalPeriodModuleNavigations = new HashSet<NlpendNominalTran>();
            NlpendNominalTranSourceNavigations = new HashSet<NlpendNominalTran>();
            PcintegrationOptions = new HashSet<PcintegrationOption>();
            PlpendSupplierTrans = new HashSet<PlpendSupplierTran>();
            PopauthPrincipalContents = new HashSet<PopauthPrincipalContent>();
            SlpendCustomerTrans = new HashSet<SlpendCustomerTran>();
            SysaccountingModulePermisses = new HashSet<SysaccountingModulePermiss>();
            SysdocumentTypes = new HashSet<SysdocumentType>();
            SysmoduleAccountingPeriods = new HashSet<SysmoduleAccountingPeriod>();
            SysperiodBalancesLedgers = new HashSet<SysperiodBalancesLedger>();
            TsclaimSheets = new HashSet<TsclaimSheet>();
        }

        public long SysmoduleId { get; set; }
        public string Name { get; set; } = null!;
        public DateTime? DateArchiveLastRun { get; set; }
        public string? ArchiveLastRunBy { get; set; }
        public DateTime? DateBroughtForwardMaintLastRun { get; set; }
        public string? BroughtForwardMaintLastRunBy { get; set; }
        public DateTime? DateAutoAllocationLastRun { get; set; }
        public string? AutoAllocationLastRunBy { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public DateTime? DateTansactionRemovalLastRun { get; set; }
        public string? TransactionRemovalLastRunBy { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<NldeferredNominalTran> NldeferredNominalTranNominalPeriodModuleNavigations { get; set; }
        public virtual ICollection<NldeferredNominalTran> NldeferredNominalTranSourceNavigations { get; set; }
        public virtual ICollection<NlpendNominalTran> NlpendNominalTranNominalPeriodModuleNavigations { get; set; }
        public virtual ICollection<NlpendNominalTran> NlpendNominalTranSourceNavigations { get; set; }
        public virtual ICollection<PcintegrationOption> PcintegrationOptions { get; set; }
        public virtual ICollection<PlpendSupplierTran> PlpendSupplierTrans { get; set; }
        public virtual ICollection<PopauthPrincipalContent> PopauthPrincipalContents { get; set; }
        public virtual ICollection<SlpendCustomerTran> SlpendCustomerTrans { get; set; }
        public virtual ICollection<SysaccountingModulePermiss> SysaccountingModulePermisses { get; set; }
        public virtual ICollection<SysdocumentType> SysdocumentTypes { get; set; }
        public virtual ICollection<SysmoduleAccountingPeriod> SysmoduleAccountingPeriods { get; set; }
        public virtual ICollection<SysperiodBalancesLedger> SysperiodBalancesLedgers { get; set; }
        public virtual ICollection<TsclaimSheet> TsclaimSheets { get; set; }
    }
}
