using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PopintrastatVw
    {
        public string Code { get; set; } = null!;
        public string CommodityCode { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public string DocumentNo { get; set; } = null!;
        public string? SupplierCountryCode { get; set; }
        public string? DocumentCountryCode { get; set; }
        public string? OriginCountryCode { get; set; }
        public bool SuppressNetMass { get; set; }
        public decimal Weight { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
        public int ArrivalDespatch { get; set; }
        public decimal ReceiptReturnQuantity { get; set; }
        public decimal StockUnitRcptRtnQuantity { get; set; }
        public decimal StockUnitLineQuantity { get; set; }
        public bool UsesSupplementaryUnit { get; set; }
        public decimal SupplementaryUnitConversionRatio { get; set; }
        public long PoporderReturnId { get; set; }
        public long PopreceiptReturnLineId { get; set; }
        public DateTime? ReceiptReturnDate { get; set; }
        public short PrintSequenceNumber { get; set; }
        public bool SingleDeliveryAddress { get; set; }
        public long? PlsupplierAccountId { get; set; }
        public long ItemId { get; set; }
        public long IntrastatStatusId { get; set; }
        public string? SupplierAccountNumber { get; set; }
        public decimal MultipleOfBaseUnit { get; set; }
    }
}
