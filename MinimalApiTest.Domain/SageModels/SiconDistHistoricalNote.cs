using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconDistHistoricalNote
    {
        public long SiconDistHistoricalNoteId { get; set; }
        public long? CustomerId { get; set; }
        public long? SoporderReturnLineId { get; set; }
        public long? ItemId { get; set; }
        public bool? OnlyForThisSalesOrderLine { get; set; }
        public bool UseColour { get; set; }
        public string? Colour { get; set; }
        public bool UseHoverNote { get; set; }
        public string? HoverNote { get; set; }
        public bool UseHyperLinkNote { get; set; }
        public string? HyperLinkNote { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
