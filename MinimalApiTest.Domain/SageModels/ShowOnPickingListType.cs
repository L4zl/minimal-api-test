using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class ShowOnPickingListType
    {
        public ShowOnPickingListType()
        {
            SoporderReturnLineArches = new HashSet<SoporderReturnLineArch>();
            SoporderReturnLines = new HashSet<SoporderReturnLine>();
        }

        public long ShowOnPickingListTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SoporderReturnLineArch> SoporderReturnLineArches { get; set; }
        public virtual ICollection<SoporderReturnLine> SoporderReturnLines { get; set; }
    }
}
