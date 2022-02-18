using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWorkPatternLineBreak
    {
        public long SiconWorkPatternLineBreakId { get; set; }
        public long? SiJcworkPatternId { get; set; }
        public int JcrateNum { get; set; }
        public decimal Monday { get; set; }
        public decimal MondayMinHours { get; set; }
        public decimal Tuesday { get; set; }
        public decimal TuesdayMinHours { get; set; }
        public decimal Wednesday { get; set; }
        public decimal WednesdayMinHours { get; set; }
        public decimal Thursday { get; set; }
        public decimal ThursdayMinHours { get; set; }
        public decimal Friday { get; set; }
        public decimal FridayMinHours { get; set; }
        public decimal Saturday { get; set; }
        public decimal SaturdayMinHours { get; set; }
        public decimal Sunday { get; set; }
        public decimal SundayMinHours { get; set; }
        public int BreakRateType { get; set; }
    }
}
