using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscorrectionTranType
    {
        public SyscorrectionTranType()
        {
            CbpostedAccountTrans = new HashSet<CbpostedAccountTran>();
            NldeferredNominalTrans = new HashSet<NldeferredNominalTran>();
            NlhistoricalNominalTrans = new HashSet<NlhistoricalNominalTran>();
            NlpendNominalTrans = new HashSet<NlpendNominalTran>();
            NlpostedNominalTrans = new HashSet<NlpostedNominalTran>();
            PlhistoricalSupplierTrans = new HashSet<PlhistoricalSupplierTran>();
            PlpostedSupplierTrans = new HashSet<PlpostedSupplierTran>();
            SlhistoricalCustomerTrans = new HashSet<SlhistoricalCustomerTran>();
            SlpostedCustomerTrans = new HashSet<SlpostedCustomerTran>();
        }

        public long SyscorrectionTranTypeId { get; set; }
        public string Name { get; set; } = null!;
        public byte[] OpLock { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime DateTimeUpdated { get; set; }

        public virtual ICollection<CbpostedAccountTran> CbpostedAccountTrans { get; set; }
        public virtual ICollection<NldeferredNominalTran> NldeferredNominalTrans { get; set; }
        public virtual ICollection<NlhistoricalNominalTran> NlhistoricalNominalTrans { get; set; }
        public virtual ICollection<NlpendNominalTran> NlpendNominalTrans { get; set; }
        public virtual ICollection<NlpostedNominalTran> NlpostedNominalTrans { get; set; }
        public virtual ICollection<PlhistoricalSupplierTran> PlhistoricalSupplierTrans { get; set; }
        public virtual ICollection<PlpostedSupplierTran> PlpostedSupplierTrans { get; set; }
        public virtual ICollection<SlhistoricalCustomerTran> SlhistoricalCustomerTrans { get; set; }
        public virtual ICollection<SlpostedCustomerTran> SlpostedCustomerTrans { get; set; }
    }
}
