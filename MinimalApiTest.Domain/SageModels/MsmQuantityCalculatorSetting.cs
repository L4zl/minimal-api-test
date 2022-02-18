﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmQuantityCalculatorSetting
    {
        public long MsmQuantityCalculatorSettingId { get; set; }
        public string? LabelInput { get; set; }
        public string? Label1 { get; set; }
        public string? Label2 { get; set; }
        public string? Label3 { get; set; }
        public string? Label4 { get; set; }
        public string? Label5 { get; set; }
        public long? Operator1 { get; set; }
        public long? Operator2 { get; set; }
        public long? Operator3 { get; set; }
        public long? Operator4 { get; set; }
        public long? Operator5 { get; set; }
        public bool? Percent1 { get; set; }
        public bool? Percent2 { get; set; }
        public bool? Percent3 { get; set; }
        public bool? Percent4 { get; set; }
        public bool? Percent5 { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
        public decimal? Value4 { get; set; }
        public decimal? Value5 { get; set; }
        public byte[]? OpLock { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
