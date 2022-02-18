﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconCfmmanualsByMonthView
    {
        public string? Title { get; set; }
        public string Description { get; set; } = null!;
        public long SiconCfmmanualId { get; set; }
        public long NlnominalAccountId { get; set; }
        public long SiconCfmsectionId { get; set; }
        public DateTime? DueDate { get; set; }
        public long ForecastDateForeignId { get; set; }
        public string ForecastDateSource { get; set; } = null!;
        public long SiconCfmforecastDateId { get; set; }
        public decimal? Value { get; set; }
        public int? HasMemos { get; set; }
    }
}