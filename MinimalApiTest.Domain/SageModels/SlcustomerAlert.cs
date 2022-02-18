using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SlcustomerAlert
    {
        public long SlcustomerAlertId { get; set; }
        public long SlcustomerAccountId { get; set; }
        public string AlertText { get; set; } = null!;
        public string AlertUpdatedBy { get; set; } = null!;
        public bool? AlertStatus { get; set; }
        public long SelectedForms { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual SlcustomerAccount SlcustomerAccount { get; set; } = null!;
    }
}
