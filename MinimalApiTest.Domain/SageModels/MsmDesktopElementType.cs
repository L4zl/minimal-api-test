using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmDesktopElementType
    {
        public MsmDesktopElementType()
        {
            MsmDesktopElements = new HashSet<MsmDesktopElement>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmDesktopElementTypeId { get; set; }
        /// <summary>
        /// Element Type.  e.g. Toolbar Item, Menu Item etc.
        /// </summary>
        public string Description { get; set; } = null!;

        public virtual ICollection<MsmDesktopElement> MsmDesktopElements { get; set; }
    }
}
