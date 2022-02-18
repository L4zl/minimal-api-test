using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SoprepeatOrderType
    {
        public SoprepeatOrderType()
        {
            SoprepeatOrderSchedules = new HashSet<SoprepeatOrderSchedule>();
        }

        public long SoprepeatOrderTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SoprepeatOrderSchedule> SoprepeatOrderSchedules { get; set; }
    }
}
