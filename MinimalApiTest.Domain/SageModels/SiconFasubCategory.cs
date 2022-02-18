using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconFasubCategory
    {
        public long SubCategoryId { get; set; }
        public string? SubCategoryDescription { get; set; }
        public long CategoryId { get; set; }
        public bool? Removed { get; set; }
        public string? SpareText1 { get; set; }
        public string? SpareText2 { get; set; }
        public string? SpareText3 { get; set; }
        public decimal? SpareNumber1 { get; set; }
        public decimal? SpareNumber2 { get; set; }
        public decimal? SpareNumber3 { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? UpdatedUser { get; set; }
        public long? DefaultDepreciationTypeId { get; set; }
        public string? DefaultWhenToPostDepreciation { get; set; }
        public decimal? DefaultExpectedLife { get; set; }
        public decimal? DefaultDepreciationRate { get; set; }
    }
}
