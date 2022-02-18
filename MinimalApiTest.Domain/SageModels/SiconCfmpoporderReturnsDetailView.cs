using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmpoporderReturnsDetailView
    {
        public long? PlsupplierAccountId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? DueDate { get; set; }
        public long PoporderReturnId { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueAccount { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? NetValueAccount { get; set; }
        public long SyscurrencyId { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long ForecastDateForeignId { get; set; }
        public long SiconCfmforecastDateId { get; set; }
        public int? HasMemos { get; set; }
    }
}
