using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class PcprojectContact
    {
        public long PcprojectContactId { get; set; }
        public long PcprojectItemId { get; set; }
        public string Description { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string TelephoneNumber { get; set; } = null!;
        public string PostalName { get; set; } = null!;
        public string ContactAddress1 { get; set; } = null!;
        public string ContactAddress2 { get; set; } = null!;
        public string ContactAddress3 { get; set; } = null!;
        public string ContactAddress4 { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool? DeliveryAddress { get; set; }
        public DateTime DateTimeCreated { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public string ContactCity { get; set; } = null!;
        public string ContactCounty { get; set; } = null!;
        public DateTime DateTimeUpdated { get; set; }

        public virtual PcprojectItem PcprojectItem { get; set; } = null!;
    }
}
