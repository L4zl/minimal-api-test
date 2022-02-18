using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconWabsopdesktopListView
    {
        public long SoporderReturnId { get; set; }
        public int PickStatus { get; set; }
        public string PickStatusName { get; set; } = null!;
        public string DocumentNo { get; set; } = null!;
        public long? CustomerId { get; set; }
        public string? CustomerAccountName { get; set; }
        public string? CustomerAccountNumber { get; set; }
        public DateTime? HeaderPromisedDate { get; set; }
        public string? CountryCode { get; set; }
        public string Priority { get; set; } = null!;
        public bool? ReadyToPick { get; set; }
        public string? BeingPickedBy { get; set; }
        public string? AssignedUser { get; set; }
    }
}
