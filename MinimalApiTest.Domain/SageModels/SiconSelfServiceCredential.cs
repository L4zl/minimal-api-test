using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SiconSelfServiceCredential
    {
        public long SiconSelfServiceCredentialsId { get; set; }
        public long? ContactId { get; set; }
        public string? ContactType { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
