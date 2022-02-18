using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmSearchCondition
    {
        public MsmSearchCondition()
        {
            MsmSearchLines = new HashSet<MsmSearchLine>();
        }

        /// <summary>
        /// Primary Key.
        /// </summary>
        public long MsmSearchConditionId { get; set; }
        /// <summary>
        /// The name of the condition.
        /// </summary>
        public string Name { get; set; } = null!;

        public virtual ICollection<MsmSearchLine> MsmSearchLines { get; set; }
    }
}
