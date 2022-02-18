﻿using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmDateRollOnExclusion
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmDateRollOnExclusionId { get; set; }
        /// <summary>
        /// Reason for Exclusion
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Table Name to Exclude.  If a Table Name is specIFied AND the Column Name is left blank, then all columns in the table will be excluded.
        /// </summary>
        public string? ExcludeTableName { get; set; }
        /// <summary>
        /// Column Name to exclude.  If a Column Name is specIFied AND the Table Name is left blank, then all columns with this name in all tables will be excluded.
        /// </summary>
        public string? ExcludeColumnName { get; set; }
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
