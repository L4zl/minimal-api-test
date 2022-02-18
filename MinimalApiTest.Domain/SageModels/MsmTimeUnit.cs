﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmTimeUnit
    {
        public MsmTimeUnit()
        {
            MsmResourceTimeUnits = new HashSet<MsmResourceTimeUnit>();
        }

        public long MsmTimeUnitId { get; set; }
        public string Name { get; set; } = null!;
        public int? Hours { get; set; }
        public byte? Minutes { get; set; }
        public byte? Seconds { get; set; }
        public bool Fixed { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MsmResourceTimeUnit> MsmResourceTimeUnits { get; set; }
    }
}
