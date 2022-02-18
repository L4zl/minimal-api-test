using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconConstructionAppCert
    {
        public long SiconConstructionAppCertId { get; set; }
        public string Qsreference { get; set; } = null!;
        public DateTime? ApprovalDate { get; set; }
        public string Note { get; set; } = null!;
        public string PostingReference { get; set; } = null!;
        public DateTime? PostedDate { get; set; }
        public DateTime? LastUpdatedDateTime { get; set; }
        public string LastUpdatedByUserId { get; set; } = null!;
        public decimal? GrossAmount { get; set; }
        public decimal? GrossRetention { get; set; }
        public decimal? GrossDiscount { get; set; }
        public decimal? GrossCis { get; set; }
        public decimal? GrossCitb { get; set; }
        public decimal? PreviousAmount { get; set; }
        public decimal? PreviousRetention { get; set; }
        public decimal? PreviousDiscount { get; set; }
        public decimal? PreviousCis { get; set; }
        public decimal? PreviousCitb { get; set; }
        public decimal? ThisAmount { get; set; }
        public decimal? ThisRetention { get; set; }
        public decimal? ThisDiscount { get; set; }
        public decimal? ThisCis { get; set; }
        public decimal? ThisCitb { get; set; }
        public decimal? ThisCisrate { get; set; }
        public decimal? ThisCitbrate { get; set; }
        public decimal? GrossTax { get; set; }
        public decimal? PreviousTax { get; set; }
        public decimal? ThisTax { get; set; }
    }
}
