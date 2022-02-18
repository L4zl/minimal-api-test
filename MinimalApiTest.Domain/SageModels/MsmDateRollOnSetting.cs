using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmDateRollOnSetting
    {
        public long MsmDateRollOnSettingId { get; set; }
        /// <summary>
        /// The pivot date to use when calculating roll on
        /// </summary>
        public DateTime? OriginalDate { get; set; }
        /// <summary>
        /// The date to use to calculate the amount of roll on
        /// </summary>
        public DateTime? NewDate { get; set; }
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required By ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
