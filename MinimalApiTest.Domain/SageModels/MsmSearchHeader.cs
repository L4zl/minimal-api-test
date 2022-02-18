using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmSearchHeader
    {
        public MsmSearchHeader()
        {
            MsmSearchLines = new HashSet<MsmSearchLine>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmSearchHeaderId { get; set; }
        /// <summary>
        /// The name of the search.
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// The name of the user this search is visible to.  Leave blank to make the search visible to all users.
        /// </summary>
        public string? UserName { get; set; }
        /// <summary>
        /// The unqualIFied name of the form this search will be displayed on.
        /// </summary>
        public string FormName { get; set; } = null!;
        /// <summary>
        /// Required by ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// Required by ObjectStore
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<MsmSearchLine> MsmSearchLines { get; set; }
    }
}
