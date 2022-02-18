using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmUserSetting
    {
        public long MsmUserSettingId { get; set; }
        public string UserName { get; set; } = null!;
        public bool ShowWelcomePageAtStartup { get; set; }
        public bool? ShowImageThumbnails { get; set; }
        /// <summary>
        /// Required by ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// GetDate()
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }
    }
}
