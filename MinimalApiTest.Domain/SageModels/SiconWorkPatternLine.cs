using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWorkPatternLine
    {
        public long SiJcWorkPatternLineId { get; set; }
        public long SiJcWorkPatternId { get; set; }
        public int? JcrateNum { get; set; }
        public int? Priority { get; set; }
        public decimal? Monday { get; set; }
        public decimal? Tuesday { get; set; }
        public decimal? Wednesday { get; set; }
        public decimal? Thursday { get; set; }
        public decimal? Friday { get; set; }
        public decimal? Saturday { get; set; }
        public decimal? Sunday { get; set; }
        public decimal? BankHoliday { get; set; }
        public DateTime? MondayFrom { get; set; }
        public DateTime? MondayTo { get; set; }
        public DateTime? TuesdayFrom { get; set; }
        public DateTime? TuesdayTo { get; set; }
        public DateTime? WednesdayFrom { get; set; }
        public DateTime? WednesdayTo { get; set; }
        public DateTime? ThursdayFrom { get; set; }
        public DateTime? ThursdayTo { get; set; }
        public DateTime? FridayFrom { get; set; }
        public DateTime? FridayTo { get; set; }
        public DateTime? SaturdayFrom { get; set; }
        public DateTime? SaturdayTo { get; set; }
        public DateTime? SundayFrom { get; set; }
        public DateTime? SundayTo { get; set; }
        public DateTime? BankHolidayFrom { get; set; }
        public DateTime? BankHolidayTo { get; set; }
        public decimal WeeklyHours { get; set; }
    }
}
