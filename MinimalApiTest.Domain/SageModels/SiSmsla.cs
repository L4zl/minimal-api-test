using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiSmsla
    {
        public long SiSmslaid { get; set; }
        public string? Name { get; set; }
        public long? TimeUnitId { get; set; }
        public decimal? TimeQuantity { get; set; }
        public decimal? WarningQuantity { get; set; }
        public DateTime? OfficeHoursFromMon { get; set; }
        public DateTime? OfficeHoursToMon { get; set; }
        public DateTime? OfficeHoursFromTue { get; set; }
        public DateTime? OfficeHoursToTue { get; set; }
        public DateTime? OfficeHoursFromWed { get; set; }
        public DateTime? OfficeHoursToWed { get; set; }
        public DateTime? OfficeHoursFromThu { get; set; }
        public DateTime? OfficeHoursToThu { get; set; }
        public DateTime? OfficeHoursFromFri { get; set; }
        public DateTime? OfficeHoursToFri { get; set; }
        public DateTime? OfficeHoursFromSat { get; set; }
        public DateTime? OfficeHoursToSat { get; set; }
        public DateTime? OfficeHoursFromSun { get; set; }
        public DateTime? OfficeHoursToSun { get; set; }
        public bool? Mon24h { get; set; }
        public bool? Tues24h { get; set; }
        public bool? Weds24h { get; set; }
        public bool? Thurs24h { get; set; }
        public bool? Fri24h { get; set; }
        public bool? Sat24h { get; set; }
        public bool? Sun24h { get; set; }
        public long? OfficeHoursTicksSun { get; set; }
        public int? SlatypeId { get; set; }
    }
}
