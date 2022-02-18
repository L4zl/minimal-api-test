using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconArchivedStkTransHist
    {
        public long SiconArchivedStkTransHistId { get; set; }
        public long? SiconArchivedStocktransferId { get; set; }
        public int HistoryType { get; set; }
        public string Description { get; set; } = null!;
        public DateTime? DateTime { get; set; }
        public string Username { get; set; } = null!;
    }
}
