using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopquotationLinesView
    {
        public long MmssoqlSoporderReturnId { get; set; }
        public int? MmssoqlPrintSequenceNumber { get; set; }
        public string? MmssoqlItemCode { get; set; }
        public string MmssoqlItemDescription { get; set; } = null!;
        public double? MmssoqlLineQuantity { get; set; }
        public double? MmssoqlUnitSellingPrice { get; set; }
        public double? MmssoqlUnitDiscountPercent { get; set; }
        public double? MmssoqlLineTotalValue { get; set; }
        public double? MmssoqlLineTaxValue { get; set; }
        public double? MmssoqlTaxRate { get; set; }
        public short MmssoqlCode { get; set; }
        public string MmssoqlDocumentNo { get; set; } = null!;
        public long MmssoqlLineTypeId { get; set; }
    }
}
