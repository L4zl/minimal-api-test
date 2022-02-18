using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderView
    {
        public string? MmssooCustomerAccountNumber { get; set; }
        public string MmssooOrderDocumentNo { get; set; } = null!;
        public DateTime? MmssooDocumentDate { get; set; }
        public string? MmssooEarlySettlementDiscount { get; set; }
        public double? MmssooTotalGrossValueIncSett { get; set; }
        public double? MmssooTotalNetValue { get; set; }
        public double? MmssooTotalTaxValue { get; set; }
        public double? MmssooTotalGrossValue { get; set; }
        public double? MmssooDocumentDiscountPercent { get; set; }
        public double? MmssooSubtotalGoodsValue { get; set; }
        public double? MmssooSubtotalChargesNetValue { get; set; }
        public double? MmssooSubtotalChargesTaxValue { get; set; }
        public double? MmssooSubtotalDiscountValue { get; set; }
        public string? MmssooDelPostalName { get; set; }
        public string? MmssooDelAddressLine1 { get; set; }
        public string? MmssooDelAddressLine2 { get; set; }
        public string? MmssooDelAddressLine3 { get; set; }
        public string? MmssooDelAddressLine4 { get; set; }
        public string? MmssooDelAddressCity { get; set; }
        public string? MmssooDelAddressCounty { get; set; }
        public string? MmssooDelPostCode { get; set; }
        public string? MmssooAddressLine1 { get; set; }
        public string? MmssooAddressLine2 { get; set; }
        public string? MmssooAddressLine3 { get; set; }
        public string? MmssooAddressLine4 { get; set; }
        public string? MmssooAddressCity { get; set; }
        public string? MmssooAddressCounty { get; set; }
        public string? MmssooPostCode { get; set; }
        public bool MmssooUseInvoiceAddress { get; set; }
        public long MmssooSoporderReturnId { get; set; }
        public string MmssooCustomerDocumentNo { get; set; } = null!;
        public long MmssooDocumentTypeId { get; set; }
        public string? MmssooCustomerAccountName { get; set; }
        public long? MmssooSlcustomerAccountId { get; set; }
    }
}
