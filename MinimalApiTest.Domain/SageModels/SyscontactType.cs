using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class SyscontactType
    {
        public SyscontactType()
        {
            PlfactorHouseContacts = new HashSet<PlfactorHouseContact>();
            PlsupplierContactValues = new HashSet<PlsupplierContactValue>();
            SlcustomerContactValues = new HashSet<SlcustomerContactValue>();
            SyscompanyContacts = new HashSet<SyscompanyContact>();
        }

        public long SyscontactTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<PlfactorHouseContact> PlfactorHouseContacts { get; set; }
        public virtual ICollection<PlsupplierContactValue> PlsupplierContactValues { get; set; }
        public virtual ICollection<SlcustomerContactValue> SlcustomerContactValues { get; set; }
        public virtual ICollection<SyscompanyContact> SyscompanyContacts { get; set; }
    }
}
