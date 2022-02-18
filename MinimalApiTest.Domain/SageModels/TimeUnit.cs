using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class TimeUnit
    {
        public TimeUnit()
        {
            SoprepeatOrderSchedules = new HashSet<SoprepeatOrderSchedule>();
            StockItemSuppliers = new HashSet<StockItemSupplier>();
        }

        public long TimeUnitId { get; set; }
        public string TimeUnitName { get; set; } = null!;
        public short MultipleOfDays { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<SoprepeatOrderSchedule> SoprepeatOrderSchedules { get; set; }
        public virtual ICollection<StockItemSupplier> StockItemSuppliers { get; set; }
    }
}
