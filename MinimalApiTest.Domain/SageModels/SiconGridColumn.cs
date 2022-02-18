using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconGridColumn
    {
        public long SiconGridColumnId { get; set; }
        public string GridName { get; set; } = null!;
        public string ColumnName { get; set; } = null!;
        public bool Visible { get; set; }
        public int Sequence { get; set; }
        public string CustomUser { get; set; } = null!;
    }
}
