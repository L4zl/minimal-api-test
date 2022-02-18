using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmplpostedSupplierTransDetailView
    {
        public long PlpostedSupplierTranId { get; set; }
        public long PlsupplierAccountId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime? DueDate { get; set; }
        public long ForecastDateForeignId { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long SiconCfmforecastDateId { get; set; }
        public decimal? Value { get; set; }
        public decimal? ValueAccount { get; set; }
        public long SyscurrencyId { get; set; }
        public int? HasMemos { get; set; }
        public int? Flags { get; set; }
        public int BadDebt { get; set; }
    }
}
