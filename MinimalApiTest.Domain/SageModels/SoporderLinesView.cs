using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoporderLinesView
    {
        public long MmssoolSoporderReturnId { get; set; }
        public int? MmssoolPrintSequenceNumber { get; set; }
        public string? MmssoolItemCode { get; set; }
        public string MmssoolItemDescription { get; set; } = null!;
        public double? MmssoolLineQuantity { get; set; }
        public double? MmssoolUnitSellingPrice { get; set; }
        public double? MmssoolUnitDiscountPercent { get; set; }
        public double? MmssoolLineTotalValue { get; set; }
        public double? MmssoolLineTaxValue { get; set; }
        public double? MmssoolTaxRate { get; set; }
        public short MmssoolCode { get; set; }
        public string MmssoolDocumentNo { get; set; } = null!;
        public double? MmssoolAllocatedQuantity { get; set; }
        public double? MmssoolDespatchReceiptQuantity { get; set; }
        public double? MmssoolInvoiceCreditQuantity { get; set; }
        public long? MmssoolPoporderReturnLineId { get; set; }
        public string MmssoolPoporder { get; set; } = null!;
        public string MmssoolComplete { get; set; } = null!;
        public long MmssoolLineTypeId { get; set; }
    }
}
