using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Syscurrency
    {
        public Syscurrency()
        {
            Cbaccounts = new HashSet<Cbaccount>();
            CbpostedAccountTrans = new HashSet<CbpostedAccountTran>();
            NldeferredNominalTrans = new HashSet<NldeferredNominalTran>();
            NlhistoricalNominalTrans = new HashSet<NlhistoricalNominalTran>();
            NlpendNominalTrans = new HashSet<NlpendNominalTran>();
            NlpostedNominalTrans = new HashSet<NlpostedNominalTran>();
            OrderValueDiscounts = new HashSet<OrderValueDiscount>();
            PcprojectEntries = new HashSet<PcprojectEntry>();
            PlpendSupplierBatchTrans = new HashSet<PlpendSupplierBatchTran>();
            PlpendSupplierTrans = new HashSet<PlpendSupplierTran>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            PriceBands = new HashSet<PriceBand>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlpendCustomerTrans = new HashSet<SlpendCustomerTran>();
            SoporderReturnArches = new HashSet<SoporderReturnArch>();
            SoporderReturns = new HashSet<SoporderReturn>();
            SoppaymentMethods = new HashSet<SoppaymentMethod>();
            StockItemDiscounts = new HashSet<StockItemDiscount>();
            SysexchangeRateHistories = new HashSet<SysexchangeRateHistory>();
            SysperiodExchangeRates = new HashSet<SysperiodExchangeRate>();
            TsclaimSheets = new HashSet<TsclaimSheet>();
        }

        public long SyscurrencyId { get; set; }
        public long SysexchangeRateAmendTypeId { get; set; }
        public long SysexchangeRateTypeId { get; set; }
        public long SyscurrencyIsocodeId { get; set; }
        public string Name { get; set; } = null!;
        public string Symbol { get; set; } = null!;
        public decimal OneUnitBaseEquals { get; set; }
        public decimal OneEuroEquals { get; set; }
        public decimal AccumulatedExchangeRateGain { get; set; }
        public string? NominalAccountNumber { get; set; }
        public string? NominalCostCentre { get; set; }
        public string? NominalDepartment { get; set; }
        public bool ThisIsBaseCurrency { get; set; }
        public bool ThisIsEuroCurrency { get; set; }
        public bool? UseForNewAccounts { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
        public bool IsSagePaymentsCurrency { get; set; }
        public decimal SagePaymentsRate { get; set; }

        public virtual SyscurrencyIsocode SyscurrencyIsocode { get; set; } = null!;
        public virtual SysexchangeRateAmendType SysexchangeRateAmendType { get; set; } = null!;
        public virtual SysexchangeRateType SysexchangeRateType { get; set; } = null!;
        public virtual ICollection<Cbaccount> Cbaccounts { get; set; }
        public virtual ICollection<CbpostedAccountTran> CbpostedAccountTrans { get; set; }
        public virtual ICollection<NldeferredNominalTran> NldeferredNominalTrans { get; set; }
        public virtual ICollection<NlhistoricalNominalTran> NlhistoricalNominalTrans { get; set; }
        public virtual ICollection<NlpendNominalTran> NlpendNominalTrans { get; set; }
        public virtual ICollection<NlpostedNominalTran> NlpostedNominalTrans { get; set; }
        public virtual ICollection<OrderValueDiscount> OrderValueDiscounts { get; set; }
        public virtual ICollection<PcprojectEntry> PcprojectEntries { get; set; }
        public virtual ICollection<PlpendSupplierBatchTran> PlpendSupplierBatchTrans { get; set; }
        public virtual ICollection<PlpendSupplierTran> PlpendSupplierTrans { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<PriceBand> PriceBands { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlpendCustomerTran> SlpendCustomerTrans { get; set; }
        public virtual ICollection<SoporderReturnArch> SoporderReturnArches { get; set; }
        public virtual ICollection<SoporderReturn> SoporderReturns { get; set; }
        public virtual ICollection<SoppaymentMethod> SoppaymentMethods { get; set; }
        public virtual ICollection<StockItemDiscount> StockItemDiscounts { get; set; }
        public virtual ICollection<SysexchangeRateHistory> SysexchangeRateHistories { get; set; }
        public virtual ICollection<SysperiodExchangeRate> SysperiodExchangeRates { get; set; }
        public virtual ICollection<TsclaimSheet> TsclaimSheets { get; set; }
    }
}
