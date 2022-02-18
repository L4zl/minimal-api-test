using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmSearchJoinType
    {
        public MsmSearchJoinType()
        {
            MsmSearchLines = new HashSet<MsmSearchLine>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmSearchJoinTypeId { get; set; }
        /// <summary>
        /// The name of the join
        /// </summary>
        public string Name { get; set; } = null!;

        public virtual ICollection<MsmSearchLine> MsmSearchLines { get; set; }
    }
}
