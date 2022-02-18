using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SystraderGenerateReasonType
    {
        public SystraderGenerateReasonType()
        {
            PlhistoricalSupplierTrans = new HashSet<PlhistoricalSupplierTran>();
            PlpendSupplierTrans = new HashSet<PlpendSupplierTran>();
            SlhistoricalCustomerTrans = new HashSet<SlhistoricalCustomerTran>();
            SlpendCustomerTrans = new HashSet<SlpendCustomerTran>();
            SlpostedCustomerTrans = new HashSet<SlpostedCustomerTran>();
        }

        public long SystraderGenerateReasonTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlhistoricalSupplierTran> PlhistoricalSupplierTrans { get; set; }
        public virtual ICollection<PlpendSupplierTran> PlpendSupplierTrans { get; set; }
        public virtual ICollection<SlhistoricalCustomerTran> SlhistoricalCustomerTrans { get; set; }
        public virtual ICollection<SlpendCustomerTran> SlpendCustomerTrans { get; set; }
        public virtual ICollection<SlpostedCustomerTran> SlpostedCustomerTrans { get; set; }
    }
}
