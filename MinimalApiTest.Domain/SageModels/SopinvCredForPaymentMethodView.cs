using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SopinvCredForPaymentMethodView
    {
        public string DocumentNo { get; set; } = null!;
        public long DocumentStatusId { get; set; }
        public long SopinvoiceCreditTypeId { get; set; }
        public long? PaymentMethodId { get; set; }
    }
}
