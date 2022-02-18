using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Nlconsolidation
    {
        public Nlconsolidation()
        {
            NlconsolidationItems = new HashSet<NlconsolidationItem>();
        }

        public long NlconsolidationId { get; set; }
        public string UniqueIdentifier { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Reference { get; set; } = null!;
        public string Narrative { get; set; } = null!;
        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string CurrencyName { get; set; } = null!;
        public decimal ExchangeRate { get; set; }

        public virtual ICollection<NlconsolidationItem> NlconsolidationItems { get; set; }
    }
}
