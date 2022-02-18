using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmUserColourSetting
    {
        public long MsmUserColourSettingId { get; set; }
        public string UserName { get; set; } = null!;
        public int? Subassembly { get; set; }
        public int? Phantom { get; set; }
        public int? Shortage { get; set; }
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
