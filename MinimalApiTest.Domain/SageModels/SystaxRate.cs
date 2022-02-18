using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystaxRate
    {
        public SystaxRate()
        {
            BlbillLines = new HashSet<BlbillLine>();
            CbdirectDebitTrans = new HashSet<CbdirectDebitTran>();
            CustDeliveryAddresses = new HashSet<CustDeliveryAddress>();
            InvinvCredTaxItems = new HashSet<InvinvCredTaxItem>();
            InvinvoiceCreditLines = new HashSet<InvinvoiceCreditLine>();
            NlheldJournalTrans = new HashSet<NlheldJournalTran>();
            NljournalTemplateTrans = new HashSet<NljournalTemplateTran>();
            PlpendSupplierAccounts = new HashSet<PlpendSupplierAccount>();
            PlpendTaxAnalysisBatchTrans = new HashSet<PlpendTaxAnalysisBatchTran>();
            PlpendTaxAnalysisTrans = new HashSet<PlpendTaxAnalysisTran>();
            Plsettings = new HashSet<Plsetting>();
            PlsupplierAccounts = new HashSet<PlsupplierAccount>();
            PopadditionalCharges = new HashSet<PopadditionalCharge>();
            PoporderReturnLines = new HashSet<PoporderReturnLine>();
            SlcustomerAccounts = new HashSet<SlcustomerAccount>();
            SlpendCustomerAccounts = new HashSet<SlpendCustomerAccount>();
            SlpendTaxAnalysisBatchTrans = new HashSet<SlpendTaxAnalysisBatchTran>();
            SlpendTaxAnalysisTrans = new HashSet<SlpendTaxAnalysisTran>();
            Slsettings = new HashSet<Slsetting>();
            SopadditionalCharges = new HashSet<SopadditionalCharge>();
            SopdocDelAddresses = new HashSet<SopdocDelAddress>();
            SopinvCredTaxItems = new HashSet<SopinvCredTaxItem>();
            SopinvCreditLineArches = new HashSet<SopinvCreditLineArch>();
            SopinvoiceCreditLines = new HashSet<SopinvoiceCreditLine>();
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
            SoppaymentArches = new HashSet<SoppaymentArch>();
            Soppayments = new HashSet<Soppayment>();
            StockItems = new HashSet<StockItem>();
            SystaxAuditTrails = new HashSet<SystaxAuditTrail>();
            SystaxPeriodRateBalances = new HashSet<SystaxPeriodRateBalance>();
            SystaxTrans = new HashSet<SystaxTran>();
            TemtaxCodeMappings = new HashSet<TemtaxCodeMapping>();
        }

        public long SystaxRateId { get; set; }
        public long SystaxEctermId { get; set; }
        public short Code { get; set; }
        public string Name { get; set; } = null!;
        public bool? IncludeInVatReturn { get; set; }
        public decimal TaxRate { get; set; }
        public string? InputNominalAccount { get; set; }
        public string? OutputNominalAccount { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SystaxEcterm SystaxEcterm { get; set; } = null!;
        public virtual ICollection<BlbillLine> BlbillLines { get; set; }
        public virtual ICollection<CbdirectDebitTran> CbdirectDebitTrans { get; set; }
        public virtual ICollection<CustDeliveryAddress> CustDeliveryAddresses { get; set; }
        public virtual ICollection<InvinvCredTaxItem> InvinvCredTaxItems { get; set; }
        public virtual ICollection<InvinvoiceCreditLine> InvinvoiceCreditLines { get; set; }
        public virtual ICollection<NlheldJournalTran> NlheldJournalTrans { get; set; }
        public virtual ICollection<NljournalTemplateTran> NljournalTemplateTrans { get; set; }
        public virtual ICollection<PlpendSupplierAccount> PlpendSupplierAccounts { get; set; }
        public virtual ICollection<PlpendTaxAnalysisBatchTran> PlpendTaxAnalysisBatchTrans { get; set; }
        public virtual ICollection<PlpendTaxAnalysisTran> PlpendTaxAnalysisTrans { get; set; }
        public virtual ICollection<Plsetting> Plsettings { get; set; }
        public virtual ICollection<PlsupplierAccount> PlsupplierAccounts { get; set; }
        public virtual ICollection<PopadditionalCharge> PopadditionalCharges { get; set; }
        public virtual ICollection<PoporderReturnLine> PoporderReturnLines { get; set; }
        public virtual ICollection<SlcustomerAccount> SlcustomerAccounts { get; set; }
        public virtual ICollection<SlpendCustomerAccount> SlpendCustomerAccounts { get; set; }
        public virtual ICollection<SlpendTaxAnalysisBatchTran> SlpendTaxAnalysisBatchTrans { get; set; }
        public virtual ICollection<SlpendTaxAnalysisTran> SlpendTaxAnalysisTrans { get; set; }
        public virtual ICollection<Slsetting> Slsettings { get; set; }
        public virtual ICollection<SopadditionalCharge> SopadditionalCharges { get; set; }
        public virtual ICollection<SopdocDelAddress> SopdocDelAddresses { get; set; }
        public virtual ICollection<SopinvCredTaxItem> SopinvCredTaxItems { get; set; }
        public virtual ICollection<SopinvCreditLineArch> SopinvCreditLineArches { get; set; }
        public virtual ICollection<SopinvoiceCreditLine> SopinvoiceCreditLines { get; set; }
        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
        public virtual ICollection<SoppaymentArch> SoppaymentArches { get; set; }
        public virtual ICollection<Soppayment> Soppayments { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<SystaxAuditTrail> SystaxAuditTrails { get; set; }
        public virtual ICollection<SystaxPeriodRateBalance> SystaxPeriodRateBalances { get; set; }
        public virtual ICollection<SystaxTran> SystaxTrans { get; set; }
        public virtual ICollection<TemtaxCodeMapping> TemtaxCodeMappings { get; set; }
    }
}
