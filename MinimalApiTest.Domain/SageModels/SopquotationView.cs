using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopquotationView
    {
        public string? MmssoqCustomerAccountNumber { get; set; }
        public string MmssoqQuoteDocumentNo { get; set; } = null!;
        public DateTime? MmssoqDocumentDate { get; set; }
        public string? MmssoqEarlySettlementDiscount { get; set; }
        public double? MmssoqTotalGrossValueIncSett { get; set; }
        public double? MmssoqTotalNetValue { get; set; }
        public double? MmssoqTotalTaxValue { get; set; }
        public double? MmssoqTotalGrossValue { get; set; }
        public double? MmssoqDocumentDiscountPercent { get; set; }
        public double? MmssoqSubtotalGoodsValue { get; set; }
        public double? MmssoqSubtotalChargesNetValue { get; set; }
        public double? MmssoqSubtotalChargesTaxValue { get; set; }
        public double? MmssoqSubtotalDiscountValue { get; set; }
        public string? MmssoqDelPostalName { get; set; }
        public string? MmssoqDelAddressLine1 { get; set; }
        public string? MmssoqDelAddressLine2 { get; set; }
        public string? MmssoqDelAddressLine3 { get; set; }
        public string? MmssoqDelAddressLine4 { get; set; }
        public string? MmssoqDelAddressCity { get; set; }
        public string? MmssoqDelAddressCounty { get; set; }
        public string? MmssoqDelPostCode { get; set; }
        public string? MmssoqAddressLine1 { get; set; }
        public string? MmssoqAddressLine2 { get; set; }
        public string? MmssoqAddressLine3 { get; set; }
        public string? MmssoqAddressLine4 { get; set; }
        public string? MmssoqAddressCity { get; set; }
        public string? MmssoqAddressCounty { get; set; }
        public string? MmssoqPostCode { get; set; }
        public bool MmssoqUseInvoiceAddress { get; set; }
        public long MmssoqSoporderReturnId { get; set; }
        public string MmssoqCustomerDocumentNo { get; set; } = null!;
        public long MmssoqDocumentTypeId { get; set; }
        public string? MmssoqCustomerAccountName { get; set; }
        public long? MmssoqSlcustomerAccountId { get; set; }
        public string? MmssoqCashAcctPostalName { get; set; }
        public string? MmssoqCashAcctAddress1 { get; set; }
        public string? MmssoqCashAcctAddress2 { get; set; }
        public string? MmssoqCashAcctAddress3 { get; set; }
        public string? MmssoqCashAcctAddress4 { get; set; }
        public string? MmssoqCashAcctAddressCity { get; set; }
        public string? MmssoqCashAcctAddressCounty { get; set; }
        public string? MmssoqCashAcctPostCode { get; set; }
    }
}
