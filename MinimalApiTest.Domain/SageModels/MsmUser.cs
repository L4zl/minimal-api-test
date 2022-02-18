using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmUser
    {
        public MsmUser()
        {
            MsmUserFeatures = new HashSet<MsmUserFeature>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmUserId { get; set; }
        /// <summary>
        /// Manufacturing user name
        /// </summary>
        public string UserName { get; set; } = null!;
        /// <summary>
        /// Accounts user name that the UserName is mapped to. This allows unIForm login entry details
        /// </summary>
        public string AccountsUserName { get; set; } = null!;
        /// <summary>
        /// Optimistic locking setting for tables that are updated by ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Creation date/time
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MsmUserFeature> MsmUserFeatures { get; set; }
    }
}
