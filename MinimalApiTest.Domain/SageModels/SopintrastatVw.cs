using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopintrastatVw
    {
        public string Code { get; set; } = null!;
        public string CommodityCode { get; set; } = null!;
        public DateTime? DocumentDate { get; set; }
        public string DocumentNo { get; set; } = null!;
        public string? DestinationCountryCode { get; set; }
        public string? OriginCountryCode { get; set; }
        public decimal Weight { get; set; }
        public bool SuppressNetMass { get; set; }
        public decimal LineTotalValue { get; set; }
        public decimal LineTaxValue { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal DocumentDiscountPercent { get; set; }
        public bool UseInvoiceAddress { get; set; }
        public int ArrivalDespatch { get; set; }
        public long? SopinvoiceCreditLineId { get; set; }
        public decimal StockUnitDespRcptQuantity { get; set; }
        public decimal DespatchReceiptQuantity { get; set; }
        public decimal StockUnitLineQuantity { get; set; }
        public string InvoiceCreditNo { get; set; } = null!;
        public short PrintSequenceNumber { get; set; }
        public DateTime DespatchReceiptDate { get; set; }
        public bool ArePricesTaxInclusive { get; set; }
        public bool UsesSupplementaryUnit { get; set; }
        public decimal SupplementaryUnitConversionRatio { get; set; }
        public long SopdespatchReceiptLineId { get; set; }
        public long SoporderReturnId { get; set; }
        public long IntrastatStatusId { get; set; }
        public string CustomerAccountNumber { get; set; } = null!;
        public decimal MultipleOfBaseUnit { get; set; }
        public decimal StockUnitInvoiceCreditQuantity { get; set; }
    }
}
