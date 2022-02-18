using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Blevent
    {
        public Blevent()
        {
            BlbillEvents = new HashSet<BlbillEvent>();
            BlclauseEvents = new HashSet<BlclauseEvent>();
            BleventAttributes = new HashSet<BleventAttribute>();
        }

        public long BleventId { get; set; }
        public long BlcontractId { get; set; }
        public long BleventStatusTypeId { get; set; }
        public int Sequence { get; set; }
        public string Description { get; set; } = null!;
        public string BleventTypeKey { get; set; } = null!;
        public string BillingSchemaName { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual Blcontract Blcontract { get; set; } = null!;
        public virtual BleventStatusType BleventStatusType { get; set; } = null!;
        public virtual ICollection<BlbillEvent> BlbillEvents { get; set; }
        public virtual ICollection<BlclauseEvent> BlclauseEvents { get; set; }
        public virtual ICollection<BleventAttribute> BleventAttributes { get; set; }
    }
}
