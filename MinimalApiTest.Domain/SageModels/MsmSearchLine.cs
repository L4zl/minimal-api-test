using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmSearchLine
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmSearchLineId { get; set; }
        /// <summary>
        /// The primary key of the MsmSearchHeader row.
        /// </summary>
        public long MsmSearchHeaderId { get; set; }
        /// <summary>
        /// The primary key of the MsmSearchJoinType row.
        /// </summary>
        public long MsmSearchJoinTypeId { get; set; }
        /// <summary>
        /// The field name to apply the search to.
        /// </summary>
        public string FieldName { get; set; } = null!;
        /// <summary>
        /// The primary key of the MsmSearchCondition row.
        /// </summary>
        public long MsmSearchConditionId { get; set; }
        /// <summary>
        /// The value to search for.
        /// </summary>
        public string SearchValue { get; set; } = null!;
        /// <summary>
        /// Required by ObjectStore
        /// </summary>
        public byte[] OpLock { get; set; } = null!;
        /// <summary>
        /// GetDate()
        /// </summary>
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual MsmSearchCondition MsmSearchCondition { get; set; } = null!;
        public virtual MsmSearchHeader MsmSearchHeader { get; set; } = null!;
        public virtual MsmSearchJoinType MsmSearchJoinType { get; set; } = null!;
    }
}
