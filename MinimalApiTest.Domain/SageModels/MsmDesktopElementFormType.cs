using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmDesktopElementFormType
    {
        public MsmDesktopElementFormType()
        {
            MsmDesktopElements = new HashSet<MsmDesktopElement>();
        }

        public long MsmDesktopElementFormTypeId { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<MsmDesktopElement> MsmDesktopElements { get; set; }
    }
}
