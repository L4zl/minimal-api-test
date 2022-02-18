using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlaccountInformationView
    {
        public string? MmsslaiPriceBandName { get; set; }
        public string MmsslaiTaxRateName { get; set; } = null!;
        public int? MmsslaiPaymentTermsInDays { get; set; }
        public double? MmsslaiEarlySettlementDiscountPercent { get; set; }
        public int? MmsslaiDaysEarlySettlementDiscApplies { get; set; }
        public string? MmsslaiInvoiceLineDiscountPercent { get; set; }
        public string? MmsslaiInvoiceDiscountPercent { get; set; }
        public string MmsslaiCompanyType { get; set; } = null!;
        public long MmsslaiSlcustomerAccountId { get; set; }
        public string? MmsslaiEarlySettlementDiscount { get; set; }
        public string? MmsslaiPaymentTermsDesc { get; set; }
        public string MmsslaiCustomerAccountNumber { get; set; } = null!;
        public string MmsslaiCustomerAccountName { get; set; } = null!;
        public string MmsslaiCurrencyName { get; set; } = null!;
        public double? MmsslaiAccountBalance { get; set; }
        public double? MmsslaiCreditLimit { get; set; }
        public string MmsslaiAddressLine1 { get; set; } = null!;
        public string MmsslaiContactName { get; set; } = null!;
        public string MmsslaiPostCode { get; set; } = null!;
        public string? MmsslaiAccountIsOnHold { get; set; }
    }
}
