using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class Temmessage
    {
        public Temmessage()
        {
            TemmessageEvents = new HashSet<TemmessageEvent>();
            TemmessageOrders = new HashSet<TemmessageOrder>();
        }

        public long TemmessageId { get; set; }
        public long? TemmessageTypeId { get; set; }
        public string Sender { get; set; } = null!;
        public string ReplyTo { get; set; } = null!;
        public string Recipient { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string MessageBody { get; set; } = null!;
        public string AccRef { get; set; } = null!;
        public short LinesUnmatched { get; set; }
        public long? TemstatusId { get; set; }
        public DateTime? MessageDate { get; set; }
        public DateTime MessageTime { get; set; }
        public long? TemlocationId { get; set; }
        public string ReceivedXmldoc { get; set; } = null!;
        public string AmendedXmldoc { get; set; } = null!;
        public string Mapiguid { get; set; } = null!;
        public long RemoteMessageIdentifier { get; set; }
        public bool ValidCheckSum { get; set; }
        public bool Unread { get; set; }
        public string CompanyName { get; set; } = null!;
        public string FromResolved { get; set; } = null!;
        public long? PopinvoiceId { get; set; }
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual PopinvCredDispute? Popinvoice { get; set; }
        public virtual Temlocation? Temlocation { get; set; }
        public virtual TemmessageType? TemmessageType { get; set; }
        public virtual Temstatus? Temstatus { get; set; }
        public virtual ICollection<TemmessageEvent> TemmessageEvents { get; set; }
        public virtual ICollection<TemmessageOrder> TemmessageOrders { get; set; }
    }
}
