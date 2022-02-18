using System;
using System.Collections.Generic;

namespace MinimalApiTest.Domain.SageModels
{
    public partial class MsmDesktopElementSourceType
    {
        public MsmDesktopElementSourceType()
        {
            MsmDesktopElements = new HashSet<MsmDesktopElement>();
        }

        /// <summary>
        /// Primary Key
        /// </summary>
        public long MsmDesktopElementSourceTypeId { get; set; }
        /// <summary>
        /// Source Description
        /// </summary>
        public string? Description { get; set; }

        public virtual ICollection<MsmDesktopElement> MsmDesktopElements { get; set; }
    }
}
