using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabbox
    {
        public long SiconWabboxId { get; set; }
        public string IdentificationNo { get; set; } = null!;
        public decimal? Height { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Weight { get; set; }
        public bool? IsUnusual { get; set; }
        public long? SoporderReturnId { get; set; }
        public long? SopdespatchReceiptId { get; set; }
        public int ShippingTypeId { get; set; }
        public string? SecondReference { get; set; }
        public bool? IsLabelPrinted { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
