using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmResourceTimeUnit
    {
        public long MsmResourceTimeUnitId { get; set; }
        /// <summary>
        /// The DB Key of the Time Unit.
        /// </summary>
        public long MsmTimeUnitId { get; set; }
        /// <summary>
        /// The DB Key of the Resource (Labour, Machine etc) that this time unit applies to.
        /// </summary>
        public long ItemId { get; set; }
        public int? Hours { get; set; }
        public byte? Minutes { get; set; }
        public byte? Seconds { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MsmTimeUnit MsmTimeUnit { get; set; } = null!;
    }
}
