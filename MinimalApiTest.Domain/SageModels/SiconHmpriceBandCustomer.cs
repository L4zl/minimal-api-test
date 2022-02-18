using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconHmpriceBandCustomer
    {
        public long SiconHmpriceBandCustomerId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? FixedAssetId { get; set; }
        public string? Name { get; set; }
        public long SiconHmtimeUnitId { get; set; }
        public decimal? QuantityFrom { get; set; }
        public decimal? QuantityTo { get; set; }
        public decimal? Price { get; set; }
    }
}
