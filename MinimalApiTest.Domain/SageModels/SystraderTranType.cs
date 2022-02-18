using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystraderTranType
    {
        public SystraderTranType()
        {
            PlhistoricalSupplierTrans = new HashSet<PlhistoricalSupplierTran>();
            PlpendSupplierBatches = new HashSet<PlpendSupplierBatch>();
            PlpendSupplierTrans = new HashSet<PlpendSupplierTran>();
            PlpostedSupplierTrans = new HashSet<PlpostedSupplierTran>();
            SlhistoricalCustomerTrans = new HashSet<SlhistoricalCustomerTran>();
            SlpendCustomerBatches = new HashSet<SlpendCustomerBatch>();
            SlpendCustomerTrans = new HashSet<SlpendCustomerTran>();
            SlpostedCustomerTrans = new HashSet<SlpostedCustomerTran>();
            Syscorrections = new HashSet<Syscorrection>();
        }

        public long SystraderTranTypeId { get; set; }
        public string Name { get; set; } = null!;
        public string SalesName { get; set; } = null!;
        public string PurchaseName { get; set; } = null!;
        public string SalesShortName { get; set; } = null!;
        public string PurchaseShortName { get; set; } = null!;

        public virtual ICollection<PlhistoricalSupplierTran> PlhistoricalSupplierTrans { get; set; }
        public virtual ICollection<PlpendSupplierBatch> PlpendSupplierBatches { get; set; }
        public virtual ICollection<PlpendSupplierTran> PlpendSupplierTrans { get; set; }
        public virtual ICollection<PlpostedSupplierTran> PlpostedSupplierTrans { get; set; }
        public virtual ICollection<SlhistoricalCustomerTran> SlhistoricalCustomerTrans { get; set; }
        public virtual ICollection<SlpendCustomerBatch> SlpendCustomerBatches { get; set; }
        public virtual ICollection<SlpendCustomerTran> SlpendCustomerTrans { get; set; }
        public virtual ICollection<SlpostedCustomerTran> SlpostedCustomerTrans { get; set; }
        public virtual ICollection<Syscorrection> Syscorrections { get; set; }
    }
}
