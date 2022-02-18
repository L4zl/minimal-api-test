using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiProductGroup
    {
        public long SiProductGroupId { get; set; }
        public long ProductGroupId { get; set; }
        public string? Text1 { get; set; }
        public string? Text2 { get; set; }
        public string? Text3 { get; set; }
        public string? Text4 { get; set; }
        public string? Text5 { get; set; }
        public string? Text6 { get; set; }
        public string? Text7 { get; set; }
        public string? Text8 { get; set; }
        public string? Text9 { get; set; }
        public string? Text10 { get; set; }
        public decimal? Number1 { get; set; }
        public decimal? Number2 { get; set; }
        public decimal? Number3 { get; set; }
        public bool? Bool1 { get; set; }
        public bool? Bool2 { get; set; }
        public bool? Bool3 { get; set; }
        public string? ExtendedDescription { get; set; }
        public string? LastUpdatedByUserId { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
    }
}
